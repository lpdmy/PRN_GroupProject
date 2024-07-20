using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDao : SingletonBase<ProductDao>
    {
        public async Task<IEnumerable<Product>> GetProducts()
        {
            List<Product> products;
            try
            {
                products = await _context.Products.AsNoTracking().Include(p => p.Category).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public async Task InsertProduct(Product product)
        {
            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            try
            {
                _context.Products.Update(product);

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task DeleteProduct(Product product)
        {
            try
            {
                var existingProduct = await _context.Products.FindAsync(product.ProductId);

                if (existingProduct != null)
                {
                    _context.Entry(existingProduct).State = EntityState.Detached;
                    _context.Products.Remove(existingProduct);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new InvalidOperationException("Product not found in database.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public async Task<Product> GetProduct(int id)
        {
            var product = new Product();
            try
            {
                product = await _context.Products.SingleOrDefaultAsync(c => c.ProductId == id);
                return product!;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public async Task<List<Product>> SearchProducts(int cateId, string searchInput)
        {
            var products = new List<Product>();
            try
            {
                if (searchInput == null || searchInput.Equals(""))
                {
                    products = await _context.Products.Where(p => p.CategoryId == cateId).ToListAsync();
                } else
                {
                    products = await _context.Products.Where(p => p.CategoryId == cateId && p.ProductName.ToUpper().Contains(searchInput.ToUpper())).ToListAsync();
                }
               
                return products!;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
