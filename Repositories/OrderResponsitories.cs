using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitories
{
    public class OrderResponsitories : IOrderResponsitoriescs
    {
        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await OrderDao.Instance.GetOrders();
        }
        public async Task InsertOrder(Order order)
        {
            await OrderDao.Instance.InsertOrder(order);
        }
        public async Task UpdateOrder(Order order)
        {
            await OrderDao.Instance.UpdateOrder(order);

        }
        public async Task DeleteOrder(Order order)
        {
            await OrderDao.Instance.DeleteOrder(order);
        }
        public async Task<Order> GetOrder(int id)
        {
            return await OrderDao.Instance.GetOrder(id);
        }

        public async Task<List<Order>> GetAllOrdersByCustomerId(int customerId)
        {
            return await OrderDao.Instance.GetAllOrdersByCustomerId(customerId);
        }
    }
}
