using Microsoft.EntityFrameworkCore;
using reviews_api.Models;

namespace reviews_api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
           
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories  { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemCategory>()
                .HasKey(ic => new { ic.ItemId, ic.CategoryId });
            modelBuilder.Entity<ItemCategory>()
                .HasOne(i => i.Item)
                .WithMany(ic => ic.ItemCategories)
                .HasForeignKey(ic => ic.ItemId);
            modelBuilder.Entity<ItemCategory>()
                .HasOne(c => c.Category)
                .WithMany(ic => ic.ItemCategories)
                .HasForeignKey(ic => ic.CategoryId);
        }
    }
}
