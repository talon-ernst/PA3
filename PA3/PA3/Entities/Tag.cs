namespace PA3.Entities
{
    public class Tag
    {
        public string? TagId { get; set; }
        public string? TagName { get; set; }

        public ICollection<TagQuoteAssociation>? TagQuotes { get; set; }
    }
}