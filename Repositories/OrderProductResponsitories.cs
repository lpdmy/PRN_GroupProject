using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitories
{
    public class OrderProductResponsitories : IOrderProductResponsitories
    {
        public async Task<IEnumerable<OrderProduct>> GetOrderProducts() { 
        return await OrderProductDao.Instance.GetOrderProducts();
        }
        public async Task InsertOrderProduct(OrderProduct orderProduct) { 
        await OrderProductDao.Instance.InsertOrderProduct(orderProduct);
        }
        public async Task UpdateOrderProduct(OrderProduct orderProduct) {
            await OrderProductDao.Instance.UpdateOrderProduct(orderProduct);
        }
        public async Task DeleteOrderProduct(OrderProduct orderProduct) {
            await OrderProductDao.Instance.DeleteOrderProduct(orderProduct);
        }
        public async Task<OrderProduct> GetOrderProduct(int order, int product) {
           return await OrderProductDao.Instance.GetOrderProduct(order,product);
        }

        public async Task<List<OrderProduct>> InsertOrderProducts(List<OrderProduct> orderProducts)
        {
            return await OrderProductDao.Instance.InsertOrderProducts(orderProducts);
        }
    }
}
