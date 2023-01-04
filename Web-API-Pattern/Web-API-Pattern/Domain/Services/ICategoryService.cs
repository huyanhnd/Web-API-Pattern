using System.Collections.Generic;
using System.Threading.Tasks;
using Web_API_Pattern.Domain.Models;
using Web_API_Pattern.Domain.Services.Communication;

namespace Web_API_Pattern.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
         Task<CategoryResponse> SaveAsync(Category category);
         Task<CategoryResponse> UpdateAsync(int id, Category category);
         Task<CategoryResponse> DeleteAsync(int id);
    }
}