using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface IWarehouseTransactionRepository : IRepository<WarehouseTransaction>
    {
        // Lấy các giao dịch của một sản phẩm
        Task<IEnumerable<WarehouseTransaction>> GetTransactionsByProductIdAsync(int productId);
    }
}

