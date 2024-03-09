namespace PA3.Entities
{
    public class TagQuoteAssociation
    {
        //Composite Keys
        public int QuoteID { get; set; }
        public int TagID { get; set; }

        //Nav Props
        public Quote? Quote { get; set; }
        public Tag? Tag { get; set; }
    }
}