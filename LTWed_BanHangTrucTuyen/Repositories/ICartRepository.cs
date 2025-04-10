using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
        Task<Cart> GetCartByUserIdAsync(string userId);
        Task AddItemToCartAsync(string userId, CartItem item);
    }
}
