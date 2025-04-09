using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LTWed_BanHangTrucTuyen.Data;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public class EFReviewRepository : EFRepository<Review>, IReviewRepository
    {
        public EFReviewRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Review>> GetApprovedReviewsByProductIdAsync(int productId)
        {
            return await _context.Reviews
                .Where(r => r.ProductId == productId && r.IsApproved)
                .ToListAsync();
        }
    }
}

