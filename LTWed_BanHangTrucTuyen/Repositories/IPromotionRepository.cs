using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface IPromotionRepository : IRepository<Promotion>
    {
        // Lấy danh sách mã khuyến mãi còn hiệu lực (chưa hết hạn và chưa đạt limit)
        Task<IEnumerable<Promotion>> GetActivePromotionsAsync();
    }
}

