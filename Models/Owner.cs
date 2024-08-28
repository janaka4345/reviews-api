namespace reviews_api.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public required Country  Country { get; set; }

        public ICollection<Item>? Items { get; set; }

    }
}
