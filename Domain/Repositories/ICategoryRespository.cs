using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Repositories
{
    public interface ICategoryRespository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
