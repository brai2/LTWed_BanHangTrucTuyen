using System.Collections.Generic;
using System.Threading.Tasks;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface IRepository<T> where T : class
    {
        // Lấy danh sách tất cả các entities
        Task<IEnumerable<T>> GetAllAsync();

        // Lấy entity theo Id (giả sử Id là kiểu int)
        Task<T> GetByIdAsync(int id);

        // Thêm mới entity
        Task AddAsync(T entity);

        // Cập nhật thông tin entity
        void Update(T entity);

        // Xóa entity
        void Delete(T entity);

        // Lưu các thay đổi về cơ sở dữ liệu
        Task SaveAsync();
    }
}

