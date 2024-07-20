using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitories
{
    public interface IProductResponsitories
    {
        Task<IEnumerable<Product>> GetProducts();
        Task InsertProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);
        Task<Product> GetProduct(int id);
        Task<List<Product>> SearchProducts(int cateId, string searchInput);

    }
}
