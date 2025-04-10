using System.Collections.Generic;
using System.Threading.Tasks;
using LTWed_BanHangTrucTuyen.Models;

namespace LTWed_BanHangTrucTuyen.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
    }
}

