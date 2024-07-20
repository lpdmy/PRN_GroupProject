using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderProductDao : SingletonBase<OrderProductDao>
    {
        public async Task<IEnumerable<OrderProduct>> GetOrderProducts()
        {
            List<OrderProduct> Orderproducts;
            try
            {
                Orderproducts = await _context.OrderProducts.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Orderproducts;
        }

        public async Task InsertOrderProduct(OrderProduct orderProduct)
        {
           
                await _context.OrderProducts.AddAsync(orderProduct);
                await _context.SaveChangesAsync();
            
        }

        public async Task<List<OrderProduct>> InsertOrderProducts(List<OrderProduct> orderProducts)
        {
            try
            {
                await _context.OrderProducts.AddRangeAsync(orderProducts);
                await _context.SaveChangesAsync();
                return orderProducts;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task UpdateOrderProduct(OrderProduct orderProduct)
        {
            try
            {
                _context.OrderProducts.Update(orderProduct);

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task DeleteOrderProduct(OrderProduct orderProduct)
        {
            try
            {
                _context.Remove(orderProduct);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<OrderProduct> GetOrderProduct(int order,int product)
        {
            var orderproduct = new OrderProduct();
            try
            {
                orderproduct = await _context.OrderProducts.SingleOrDefaultAsync(c => c.ProductId == product && c.OrderId == order);
                return orderproduct!;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}

