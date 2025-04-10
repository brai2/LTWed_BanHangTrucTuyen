using LTWed_BanHangTrucTuyen.Models;
using Microsoft.EntityFrameworkCore;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Cart> GetCartByUserIdAsync(string userId)
            => await _dbSet
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);

        public async Task AddItemToCartAsync(string userId, CartItem item)
        {
            var cart = await GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                await AddAsync(cart);
            }

            cart.CartItems.Add(item);
            await _context.SaveChangesAsync();
        }
    }

}
