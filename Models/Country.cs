﻿namespace reviews_api.Models
{
    public class Country
    {
        public int Id { get; set; }
        public required string Name { get; set; } 

        public ICollection<Owner>? Owners { get; set; }

    }
}
