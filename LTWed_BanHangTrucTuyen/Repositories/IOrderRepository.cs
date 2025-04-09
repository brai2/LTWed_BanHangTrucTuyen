using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        // Lấy danh sách đơn hàng của một khách hàng (theo CustomerId)
        Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(string customerId);

        // Lấy chi tiết đơn hàng kèm theo các OrderItem
        Task<Order> GetOrderDetailsAsync(int orderId);
    }
}

