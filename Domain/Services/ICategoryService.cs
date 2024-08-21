using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
