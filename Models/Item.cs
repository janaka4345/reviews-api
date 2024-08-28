namespace reviews_api.Models
{
    public class Item
    {
        public int Id { get; set; }
        public required string Title { get; set; } 
        public required string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public required Owner Owner { get; set; }
        public ICollection<Review>? Reviews { get; set; }

        public required ICollection<ItemCategory> ItemCategories { get; set; }


    }
}
