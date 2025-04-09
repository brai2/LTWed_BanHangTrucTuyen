using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface IReviewRepository : IRepository<Review>
    {
        // Lấy các đánh giá đã được duyệt cho một sản phẩm
        Task<IEnumerable<Review>> GetApprovedReviewsByProductIdAsync(int productId);
    }
}
