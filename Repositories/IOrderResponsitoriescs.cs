using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitories
{
    public interface IOrderResponsitoriescs
    {
        Task<IEnumerable<Order>> GetOrders();
        Task InsertOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(Order order);
        Task<Order> GetOrder(int id);

        Task<List<Order>> GetAllOrdersByCustomerId(int customerId);
    }
}
