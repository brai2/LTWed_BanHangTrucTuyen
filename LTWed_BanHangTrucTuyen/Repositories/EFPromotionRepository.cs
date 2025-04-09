using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LTWed_BanHangTrucTuyen.Data;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public class EFPromotionRepository : EFRepository<Promotion>, IPromotionRepository
    {
        public EFPromotionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Promotion>> GetActivePromotionsAsync()
        {
            var today = DateTime.UtcNow;
            return await _context.Promotions
                .Where(p => (!p.ExpirationDate.HasValue || p.ExpirationDate > today) &&
                            (p.UsageLimit == 0 || p.TimesUsed < p.UsageLimit))
                .ToListAsync();
        }
    }
}

