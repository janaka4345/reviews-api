namespace reviews_api.Models
{
    public class Review
    {
        public int Id { get; set; }
        public required string Title { get; set; } 
        public required string Description { get; set; }
        public required Reviewer Reviewer  { get; set; }
        public required Item Item { get; set; }
    }
}
