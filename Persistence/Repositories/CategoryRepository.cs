using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Persistence.Repositories;
using SupermarketAPI.Persistence.Contexts;
using SupermarketAPI.Domain.Repositories;


namespace SupermarketAPI.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRespository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}