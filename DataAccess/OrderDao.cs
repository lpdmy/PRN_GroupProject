using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDao : SingletonBase<OrderDao>
    {
        public async Task<IEnumerable<Order>> GetOrders()
        {
            List<Order> orders;
            try
            {
                orders = await _context.Orders.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public async Task InsertOrder(Order order)
        {
            
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
           
        }

        public async Task UpdateOrder(Order order)
        {
            try
            {
                var existingOrder = await _context.Orders.FindAsync(order.OrderId);
                if (existingOrder != null)
                {
                    _context.Entry(existingOrder).CurrentValues.SetValues(order);
                }
                else
                {
                    _context.Orders.Update(order);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error updating order: " + e.Message);
            }
        }

        public async Task DeleteOrder(Order order)
        {
            try
            {
                _context.Remove(order);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Order> GetOrder(int id)
        {
            var order = new Order();
            try
            {
                order = await _context.Orders
    .AsNoTracking()
    .Include(o => o.OrderProducts)
        .ThenInclude(op => op.Product)
    .SingleOrDefaultAsync(o => o.OrderId == id);
                return order!;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public async Task<List<Order>> GetAllOrdersByCustomerId(int customerId)
        {
            var listOrders = new List<Order>();
            try
            {
                listOrders = await _context.Orders.Where(c => c.CustomerId == customerId).ToListAsync();
                return listOrders!;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
