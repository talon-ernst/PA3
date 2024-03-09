using System.ComponentModel.DataAnnotations;

namespace PA3.Entities
{
    public class Quote
    {
        public int QuoteId { get; set; }

        [Required(ErrorMessage = "A quote must have content")]
        public string QuoteContent { get; set; } = null!;

        public string? QuoteAuthor { get; set; }

        public int likeCounter { get; set; } = 0;

        public ICollection<TagQuoteAssociation>? TagQuotes { get; set; }
    }
}