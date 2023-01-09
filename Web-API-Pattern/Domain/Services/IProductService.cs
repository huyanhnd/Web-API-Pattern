using System.Threading.Tasks;
using Web_API_Pattern.Domain.Models;
using Web_API_Pattern.Domain.Models.Queries;
using Web_API_Pattern.Domain.Services.Communication;

namespace Web_API_Pattern.Services
{
    public interface IProductService
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}