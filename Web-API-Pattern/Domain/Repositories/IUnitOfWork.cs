using System.Threading.Tasks;

namespace Web_API_Pattern.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}