using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        // Lấy danh sách sản phẩm theo danh mục
        Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);

        // Tìm kiếm sản phẩm theo tên hoặc từ khóa
        Task<IEnumerable<Product>> SearchProductsAsync(string keyword);
    }
}

