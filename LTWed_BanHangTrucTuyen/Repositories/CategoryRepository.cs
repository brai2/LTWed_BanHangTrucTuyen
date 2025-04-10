using LTWed_BanHangTrucTuyen.Models;
using Microsoft.EntityFrameworkCore;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Category>> GetCategoriesWithProductsAsync()
            => await _dbSet
                .Include(c => c.Products)
                .ToListAsync();
    }
}
