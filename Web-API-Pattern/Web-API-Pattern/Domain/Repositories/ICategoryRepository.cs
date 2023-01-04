using System.Collections.Generic;
using System.Threading.Tasks;
using Web_API_Pattern.Domain.Models;

namespace Web_API_Pattern.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        void Update(Category category);
        void Remove(Category category);
    }
}