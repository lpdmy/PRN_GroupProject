using System.ComponentModel.DataAnnotations;

namespace BusinessLogic
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }
    }
}
