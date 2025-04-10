using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId);
        Task<Order> GetOrderWithDetailsAsync(int orderId);
    }
}

