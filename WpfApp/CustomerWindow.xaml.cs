using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double Price { get; set; }

        // Add more properties as needed
    }

    public partial class CustomerWindow : Window
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public CustomerWindow()
        {
            InitializeComponent();
            LoadProducts(); // Load products when the window initializes
        }

        private void LoadProducts()
        {
            // Simulate fetching products from a database
            Products = GetProductsFromDatabase();
            DataContext = this; // Set the data context to this window (optional, see note below)
        }

        private List<Product> GetProductsFromDatabase()
        {
            // Replace with actual database retrieval logic
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Hamburger 1",
                    Description = "Delicious hamburger with cheese and pickles.",
                    ImagePath = "/Img/hamburger.jpg",
                    Price = 10.0
                },
                new Product
                {
                    Id = 2,
                    Name = "Hamburger 2",
                    Description = "Juicy hamburger with bacon and special sauce.",
                    ImagePath = "/Img/hamburger.jpg",
                    Price = 10.0

                },
                 new Product
                {
                    Id = 2,
                    Name = "Hamburger 2",
                    Description = "Juicy hamburger with bacon and special sauce.",
                    ImagePath = "/Img/hamburger.jpg",
                    Price = 10.0

                },
                  new Product
                {
                    Id = 2,
                    Name = "Hamburger 2",
                    Description = "Juicy hamburger with bacon and special sauce.",
                    ImagePath = "/Img/hamburger.jpg",
                    Price = 10.0

                }
            };
            return products;
        }
    }
}
