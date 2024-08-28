namespace reviews_api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public ICollection<ItemCategory>? ItemCategories { get; set; }    
    }
}
