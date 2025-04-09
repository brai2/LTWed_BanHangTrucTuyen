using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LTWed_BanHangTrucTuyen.Data;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public class EFWarehouseTransactionRepository : EFRepository<WarehouseTransaction>, IWarehouseTransactionRepository
    {
        public EFWarehouseTransactionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<WarehouseTransaction>> GetTransactionsByProductIdAsync(int productId)
        {
            return await _context.WarehouseTransactions
                .Where(wt => wt.ProductId == productId)
                .ToListAsync();
        }
    }
}

