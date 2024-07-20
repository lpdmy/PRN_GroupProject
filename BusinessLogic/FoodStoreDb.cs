using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BussinessLogic
{
    public class FoodStoreDb : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var buider = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot configuration = buider.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("FoodStoreDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
       .Property(c => c.CategoryId)
       .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .Property(p => p.ProductId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Fast food",
                    CategoryDescription = "Unhealthy"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Japanese food",
                    CategoryDescription = "Not delicious as you see"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Drink",
                    CategoryDescription = "Thirsty"
                }
                );

            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  CategoryId = 1,
                  ProductId = 1,
                  ImagePath = "/Img/hamburger.jpg",
                  Description = "Hamburger with cheese and beefsteak",
                  ProductName = "VIP Hamburger",
                  Price = 10
              },
               new Product
               {
                   CategoryId = 1,
                   ProductId = 2,
                   ImagePath = "/Img/pizza.jpg",
                   Description = "Pizza with cheese and beefsteak",
                   ProductName = "VIP Pizza",
                   Price = 50
               },
                new Product
                {
                    CategoryId = 2,
                    ProductId = 3,
                    ImagePath = "/Img/sushi.jpg",
                    Description = "Sushi is fresh",
                    ProductName = "Golden Sushi",
                    Price = 100
                },
                 new Product
                 {
                     CategoryId = 2,
                     ProductId = 4,
                     ImagePath = "/Img/sashimi.jpg",
                     Description = "Sashimi is fresh too",
                     ProductName = "Golden Sashimi",
                     Price = 60
                 },
                  new Product
                  {
                      CategoryId = 2,
                      ProductId = 5,
                      ImagePath = "/Img/sukiyaki.jpg",
                      Description = "Very very big sukiyaki",
                      ProductName = "Sukiyaki Hotpot",
                      Price = 150
                  },
                    new Product
                    {
                        CategoryId = 3,
                        ProductId = 6,
                        ImagePath = "/Img/coca.jpg",
                        Description = "Very very big sukiyaki",
                        ProductName = "Sukiyaki Hotpot",
                        Price = 15
                    }
               );
            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                {
                    CustomerId = 1,
                    Email = "mylpdde180283@fpt.edu.vn",
                    Password = "123",
                    UserName = "dieumy",
                    IsDisabled = false,
                },
                 new Customer()
                 {
                     CustomerId = 2,
                     Email = "my1lpdde180283@fpt.edu.vn",
                     Password = "123",
                     UserName = "dieumy1",
                     IsDisabled = false,

                 },
                  new Customer()
                  {
                      CustomerId = 3,
                      Email = "my2lpdde180283@fpt.edu.vn",
                      Password = "123",
                      UserName = "dieumy2",
                      IsDisabled = false,

                  }
                );

            modelBuilder.Entity<Customer>()
        .HasIndex(c => c.Email).IsUnique();

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.UserName).IsUnique();
        }


    }
}
