using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitories
{
    public interface IOrderProductResponsitories
    {
        Task<IEnumerable<OrderProduct>> GetOrderProducts();
        Task InsertOrderProduct(OrderProduct orderProduct);
        Task DeleteOrderProduct(OrderProduct orderProduct);
        Task UpdateOrderProduct(OrderProduct orderProduct);
        Task<OrderProduct> GetOrderProduct(int order, int product);
        Task<List<OrderProduct>> InsertOrderProducts(List<OrderProduct> orderProducts);
    }
}
