using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitories
{
    public class ProductResponsitories : IProductResponsitories
    {
        public async Task<IEnumerable<Product>> GetProducts()
        { 
            return await ProductDao.Instance.GetProducts();
        }
        public async Task InsertProduct(Product product) { 
        await ProductDao.Instance.InsertProduct(product);
        }
        public async Task UpdateProduct(Product product) {
            await ProductDao.Instance.UpdateProduct(product);
                
                }
        public async Task DeleteProduct(Product product) { 
        await ProductDao.Instance.DeleteProduct(product);
        }
        public async Task<Product> GetProduct(int id) { 
        return await ProductDao.Instance.GetProduct(id);
        }

        public async Task<List<Product>> SearchProducts(int cateId, string searchInput)
        {
            return await ProductDao.Instance.SearchProducts(cateId, searchInput);
        }
    }
}
