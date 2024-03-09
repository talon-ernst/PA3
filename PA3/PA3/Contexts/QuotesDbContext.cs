using Microsoft.EntityFrameworkCore;
using PA3.Entities;

namespace PA3.Contexts
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext(DbContextOptions<QuotesDbContext> options)
            : base(options) 
        { 
        }

        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagQuoteAssociation> TagQuotes {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagQuoteAssociation>().HasKey(k => new { k.QuoteID, k.TagID });

            modelBuilder.Entity<TagQuoteAssociation>().HasOne(k => k.Quote).WithMany(m => m.TagQuotes).HasForeignKey(k => k.QuoteID);

            modelBuilder.Entity<TagQuoteAssociation>().HasOne(k => k.Tag).WithMany(m => m.TagQuotes).HasForeignKey(k => k.TagID);


        }
    }
}