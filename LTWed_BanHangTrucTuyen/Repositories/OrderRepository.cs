using LTWed_BanHangTrucTuyen.Models;
using Microsoft.EntityFrameworkCore;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId)
            => await _dbSet
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .ToListAsync();

        public async Task<Order> GetOrderWithDetailsAsync(int orderId)
            => await _dbSet
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .FirstOrDefaultAsync(o => o.Id == orderId);
    }
}
