
using BackToFiorello.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace BackToFiorello.Data {


    public class AppDbContext :DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Expert> Expert { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Instagram> Instagram { get; set; }
        public DbSet<Discount> Discounts { get; set; }

    }
}
