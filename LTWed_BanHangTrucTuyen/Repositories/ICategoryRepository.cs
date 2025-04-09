using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        // Ví dụ: lấy danh sách danh mục có sản phẩm hoạt động
        Task<IEnumerable<Category>> GetCategoriesWithActiveProductsAsync();
    }
}

