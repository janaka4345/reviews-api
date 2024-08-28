namespace reviews_api.Models
{
    public class ItemCategory
    {
        public required int ItemId { get; set; }
        public required int CategoryId { get; set; }    
        public required Item Item { get; set; }
        public required Category Category { get; set; }

    }
}
