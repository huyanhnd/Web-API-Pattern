using System.Collections.Generic;
using System.Threading.Tasks;
using Web_API_Pattern.Domain.Models;
using Web_API_Pattern.Domain.Models.Queries;

namespace Web_API_Pattern.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task AddAsync(Product product);
        Task<Product> FindByIdAsync(int id);
        void Update(Product product);
        void Remove(Product product);
    }
}