using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LTWed_BanHangTrucTuyen.Data;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public class EFCategoryRepository : EFRepository<Category>, ICategoryRepository
    {
        public EFCategoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetCategoriesWithActiveProductsAsync()
        {
            return await _context.Categories
                .Include(c => c.Products)
                .Where(c => c.Products.Any(p => p.IsActive && p.InStock))
                .ToListAsync();
        }
    }
}

