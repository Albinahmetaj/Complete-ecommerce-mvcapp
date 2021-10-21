﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SinusSkateboardsWebApp.Models;

namespace SinusSkateboardsWebApp.Migrations
{
    [DbContext(typeof(AppDbContext ))]
    [Migration("20211006214830_droplistprod")]
    partial class droplistprod
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Hoodie"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Cap"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Skateboard"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Tshirt"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Wheelrock"
                        });
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.ColorCategory", b =>
                {
                    b.Property<int>("ColorCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorCategoryId");

                    b.ToTable("ColorCategories");

                    b.HasData(
                        new
                        {
                            ColorCategoryId = 1,
                            ColorName = "White"
                        },
                        new
                        {
                            ColorCategoryId = 2,
                            ColorName = "Silver"
                        },
                        new
                        {
                            ColorCategoryId = 3,
                            ColorName = "Gray"
                        },
                        new
                        {
                            ColorCategoryId = 4,
                            ColorName = "Black"
                        },
                        new
                        {
                            ColorCategoryId = 5,
                            ColorName = "Red"
                        },
                        new
                        {
                            ColorCategoryId = 6,
                            ColorName = "Yellow"
                        },
                        new
                        {
                            ColorCategoryId = 7,
                            ColorName = "Olive"
                        },
                        new
                        {
                            ColorCategoryId = 8,
                            ColorName = "Maroon"
                        },
                        new
                        {
                            ColorCategoryId = 9,
                            ColorName = "Lime"
                        },
                        new
                        {
                            ColorCategoryId = 10,
                            ColorName = "Green"
                        },
                        new
                        {
                            ColorCategoryId = 11,
                            ColorName = "Aqua"
                        },
                        new
                        {
                            ColorCategoryId = 12,
                            ColorName = "Teal"
                        },
                        new
                        {
                            ColorCategoryId = 13,
                            ColorName = "Blue"
                        },
                        new
                        {
                            ColorCategoryId = 14,
                            ColorName = "Navy"
                        },
                        new
                        {
                            ColorCategoryId = 15,
                            ColorName = "Fuschia"
                        },
                        new
                        {
                            ColorCategoryId = 16,
                            ColorName = "Purple"
                        },
                        new
                        {
                            ColorCategoryId = 17,
                            ColorName = "Other"
                        });
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ordernumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("State")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColorCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageCarouselOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageCarouselTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSaleOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photopath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorCategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ColorCategoryId = 5,
                            ImageCarouselOne = "hoodie-fire1.jpg",
                            ImageCarouselTwo = "hoodie-fire2.jpg",
                            InStock = true,
                            IsSaleOfTheWeek = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer congue convallis ligula vel ullamcorper. Donec congue gravida nulla sed sodales. Pellentesque ullamcorper eros non dolor laoreet ultrices. Maecenas et varius ex. Integer tempor eu quam a imperdiet. Integer ut euismod lacus, malesuada fringilla diam. Quisque maximus est a nisi tempus, et semper enim elementum. Cras at convallis massa. Fusce id ex sed ligula luctus elementum.",
                            Photopath = "hoodie-fire.png",
                            Price = 22.95m,
                            ShortDescription = "Our famous red hoodie!",
                            Titel = "Hoodie"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            ColorCategoryId = 16,
                            ImageCarouselOne = "purple-cap1.jpg",
                            ImageCarouselTwo = "purple-cap2.jpg",
                            InStock = true,
                            IsSaleOfTheWeek = false,
                            LongDescription = "Fusce in dictum enim. Curabitur non congue turpis. Praesent congue enim quis bibendum ultrices. Vestibulum ac libero iaculis, pharetra leo vitae, efficitur nulla. Sed cursus mauris enim, et aliquet ipsum dictum id. Sed luctus sodales hendrerit. Mauris placerat volutpat velit, eu venenatis leo. Morbi finibus lobortis laoreet. Sed erat metus, rutrum nec lectus vel, tincidunt blandit odio.",
                            Photopath = "sinus-cap-purple.png",
                            Price = 18.95m,
                            ShortDescription = "You'll love it!",
                            Titel = "Cap"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            ColorCategoryId = 17,
                            ImageCarouselOne = "skateboard-logo1.jpg",
                            ImageCarouselTwo = "skateboard-logo2.jpg",
                            InStock = true,
                            IsSaleOfTheWeek = true,
                            LongDescription = "Maecenas vel sodales eros. Ut elementum et odio ac auctor. Etiam dapibus ipsum quis ipsum tincidunt blandit. Cras porta tempor est in rhoncus. Aenean suscipit enim vel mollis iaculis. Etiam ornare bibendum orci, finibus suscipit lorem dignissim quis. Sed et lorem dui. Ut eleifend, ante in eleifend vehicula, nunc sem egestas metus, luctus ultricies sem eros et nisi. Maecenas pharetra id urna a tincidunt. Donec auctor lectus at nulla ultricies ullamcorper. Quisque semper dignissim porta. Aliquam sit amet eros id diam varius dapibus.",
                            Photopath = "sinus-skateboard-logo.png",
                            Price = 18.95m,
                            ShortDescription = "Wicked skateboard.",
                            Titel = "Skateboard"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 4,
                            ColorCategoryId = 3,
                            ImageCarouselOne = "tshirt-grey1.jpg",
                            ImageCarouselTwo = "tshirt-grey2.jpg",
                            InStock = true,
                            IsSaleOfTheWeek = true,
                            LongDescription = "Integer posuere, purus ac dapibus egestas, nisl mi finibus arcu, quis ullamcorper turpis quam in ligula. Etiam nec tellus ante. Morbi quis enim ut turpis ornare elementum. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed congue, nulla et auctor pulvinar, tortor diam interdum arcu, at volutpat risus velit at diam. Donec ut molestie ligula. Fusce ex ante, posuere nec varius feugiat, tincidunt tincidunt quam. Curabitur at magna ac justo pretium porta sit amet ut eros. Donec euismod purus nulla, rhoncus luctus erat aliquet quis.",
                            Photopath = "sinus-tshirt-grey.png",
                            Price = 15.95m,
                            ShortDescription = "Simple but deadly",
                            Titel = "Tshirt"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4,
                            ColorCategoryId = 1,
                            ImageCarouselOne = "tshirt-white1.jpg",
                            ImageCarouselTwo = "tshirt-white2.jpg",
                            InStock = true,
                            IsSaleOfTheWeek = false,
                            LongDescription = "Quisque nisl turpis, mattis feugiat efficitur et, mattis vitae risus. Nam ac ultricies mauris. Vestibulum dignissim egestas magna, eu dignissim orci vulputate id. Nam vehicula feugiat justo. Pellentesque neque lacus, elementum tempor blandit vel, imperdiet quis dui. Sed tempor orci lectus, et lobortis orci tempus vitae. Aenean volutpat vel tellus a commodo. Quisque convallis, diam id commodo dictum, massa mauris vehicula lacus, a dapibus ligula turpis tempus sem. Duis id ipsum scelerisque, consequat felis id, aliquam justo. Morbi elementum egestas orci, non tristique magna efficitur sit amet. Pellentesque tempor diam vel mauris consequat eleifend. In eget nunc nibh. Maecenas a augue id purus pharetra lacinia.",
                            Photopath = "tshirt-white.png",
                            Price = 13.95m,
                            ShortDescription = "Drip?!",
                            Titel = "Tshirt"
                        });
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.OrderDetail", b =>
                {
                    b.HasOne("SinusSkateboardsWebApp.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SinusSkateboardsWebApp.Models.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.ProductModel", b =>
                {
                    b.HasOne("SinusSkateboardsWebApp.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SinusSkateboardsWebApp.Models.ColorCategory", "ColorCategory")
                        .WithMany("Product")
                        .HasForeignKey("ColorCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ColorCategory");
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("SinusSkateboardsWebApp.Models.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.ColorCategory", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("SinusSkateboardsWebApp.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
