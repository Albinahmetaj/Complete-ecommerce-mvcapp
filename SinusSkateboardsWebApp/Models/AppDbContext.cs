using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SinusSkateboardsWebApp.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext (DbContextOptions<AppDbContext > options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ColorCategory> ColorCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Hoodie" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cap" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Skateboard" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Tshirt" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Wheelrock" });

            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 1, ColorName = "White" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 2, ColorName = "Silver" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 3, ColorName = "Gray" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 4, ColorName = "Black" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 5, ColorName = "Red" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 6, ColorName = "Yellow" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 7, ColorName = "Olive" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 8, ColorName = "Maroon" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 9, ColorName = "Lime" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 10, ColorName = "Green" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 11, ColorName = "Aqua" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 12, ColorName = "Teal" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 13, ColorName = "Blue" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 14, ColorName = "Navy" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 15, ColorName = "Fuschia" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 16, ColorName = "Purple" });
            modelBuilder.Entity<ColorCategory>().HasData(new ColorCategory { ColorCategoryId = 17, ColorName = "Other" });



            

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                ProductId = 1,
                Titel = "Hoodie",
                Price = 22.95M,
                ShortDescription = "Our famous red hoodie!",
                LongDescription =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer congue convallis ligula vel ullamcorper. Donec congue gravida nulla sed sodales. Pellentesque ullamcorper eros non dolor laoreet ultrices. Maecenas et varius ex. Integer tempor eu quam a imperdiet. Integer ut euismod lacus, malesuada fringilla diam. Quisque maximus est a nisi tempus, et semper enim elementum. Cras at convallis massa. Fusce id ex sed ligula luctus elementum.",
                CategoryId = 1,
                Photopath = "hoodie-fire.png",
                InStock = true,
                IsSaleOfTheWeek = true,
                ColorCategoryId = 5,
                ImageCarouselOne = "hoodie-fire1.jpg",
                ImageCarouselTwo = "hoodie-fire2.jpg",
                
                
            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                ProductId = 2,
                Titel = "Cap",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Fusce in dictum enim. Curabitur non congue turpis. Praesent congue enim quis bibendum ultrices. Vestibulum ac libero iaculis, pharetra leo vitae, efficitur nulla. Sed cursus mauris enim, et aliquet ipsum dictum id. Sed luctus sodales hendrerit. Mauris placerat volutpat velit, eu venenatis leo. Morbi finibus lobortis laoreet. Sed erat metus, rutrum nec lectus vel, tincidunt blandit odio.",
                CategoryId = 2,
                Photopath = "sinus-cap-purple.png",
                InStock = true,
                IsSaleOfTheWeek = false,
                ColorCategoryId = 16,
                ImageCarouselOne = "purple-cap1.jpg",
                ImageCarouselTwo = "purple-cap2.jpg",

            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                ProductId = 3,
                Titel = "Skateboard",
                Price = 18.95M,
                ShortDescription = "Wicked skateboard.",
                LongDescription =
                    "Maecenas vel sodales eros. Ut elementum et odio ac auctor. Etiam dapibus ipsum quis ipsum tincidunt blandit. Cras porta tempor est in rhoncus. Aenean suscipit enim vel mollis iaculis. Etiam ornare bibendum orci, finibus suscipit lorem dignissim quis. Sed et lorem dui. Ut eleifend, ante in eleifend vehicula, nunc sem egestas metus, luctus ultricies sem eros et nisi. Maecenas pharetra id urna a tincidunt. Donec auctor lectus at nulla ultricies ullamcorper. Quisque semper dignissim porta. Aliquam sit amet eros id diam varius dapibus.",
                CategoryId = 3,
                Photopath = "sinus-skateboard-logo.png",
                InStock = true,
                IsSaleOfTheWeek = true,
                ColorCategoryId = 17,
                ImageCarouselOne = "skateboard-logo1.jpg",
                ImageCarouselTwo = "skateboard-logo2.jpg",

            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                ProductId = 4,
                Titel = "Tshirt",
                Price = 15.95M,
                ShortDescription = "Simple but deadly",
                LongDescription =
                    "Integer posuere, purus ac dapibus egestas, nisl mi finibus arcu, quis ullamcorper turpis quam in ligula. Etiam nec tellus ante. Morbi quis enim ut turpis ornare elementum. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed congue, nulla et auctor pulvinar, tortor diam interdum arcu, at volutpat risus velit at diam. Donec ut molestie ligula. Fusce ex ante, posuere nec varius feugiat, tincidunt tincidunt quam. Curabitur at magna ac justo pretium porta sit amet ut eros. Donec euismod purus nulla, rhoncus luctus erat aliquet quis.",
                CategoryId = 4,
                Photopath = "sinus-tshirt-grey.png",
                InStock = true,
                IsSaleOfTheWeek = true,
                ColorCategoryId = 3,
                ImageCarouselOne = "tshirt-grey1.jpg",
                ImageCarouselTwo = "tshirt-grey2.jpg",

            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                ProductId = 5,
                Titel = "Tshirt",
                Price = 13.95M,
                ShortDescription = "Drip?!",
                LongDescription =
                    "Quisque nisl turpis, mattis feugiat efficitur et, mattis vitae risus. Nam ac ultricies mauris. Vestibulum dignissim egestas magna, eu dignissim orci vulputate id. Nam vehicula feugiat justo. Pellentesque neque lacus, elementum tempor blandit vel, imperdiet quis dui. Sed tempor orci lectus, et lobortis orci tempus vitae. Aenean volutpat vel tellus a commodo. Quisque convallis, diam id commodo dictum, massa mauris vehicula lacus, a dapibus ligula turpis tempus sem. Duis id ipsum scelerisque, consequat felis id, aliquam justo. Morbi elementum egestas orci, non tristique magna efficitur sit amet. Pellentesque tempor diam vel mauris consequat eleifend. In eget nunc nibh. Maecenas a augue id purus pharetra lacinia.",
                CategoryId = 4,
                Photopath = "tshirt-white.png",
                InStock = true,
                IsSaleOfTheWeek = false,
                ColorCategoryId = 1,
                ImageCarouselOne = "tshirt-white1.jpg",
                ImageCarouselTwo = "tshirt-white2.jpg",

            });

           
        }
    }
}
