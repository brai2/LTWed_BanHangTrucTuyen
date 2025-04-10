using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LTWed_BanHangTrucTuyen.Data;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
            => await _dbSet
                .Where(p => p.CategoryId == categoryId)
                .Include(p => p.Category)
                .ToListAsync();

        public async Task<IEnumerable<Product>> SearchProductsAsync(string keyword)
            => await _dbSet
                .Where(p => p.Name.Contains(keyword) || p.Description.Contains(keyword))
                .ToListAsync();

        public async Task<(IEnumerable<Product> Items, int Total)> GetPagedProductsAsync(int page, int pageSize)
        {
            var query = _dbSet.Include(p => p.Category);
            var total = await query.CountAsync();
            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (items, total);
        }
    }
}

