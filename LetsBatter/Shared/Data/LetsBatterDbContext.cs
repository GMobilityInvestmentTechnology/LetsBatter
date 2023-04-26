using Microsoft.EntityFrameworkCore;
using LetsBatter.Shared.Models;

namespace LetsBatter.Shared.Data
{
    public class LetsBatterDbContext : DbContext
    {
        public LetsBatterDbContext(DbContextOptions<LetsBatterDbContext> options) : base(options) {}

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Analytics> Analytics { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<NamePriceTest> NamePriceTests { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

    }
}
