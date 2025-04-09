using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        // Lấy danh sách địa chỉ theo UserId
        Task<IEnumerable<Address>> GetAddressesByUserIdAsync(string userId);
    }
}

