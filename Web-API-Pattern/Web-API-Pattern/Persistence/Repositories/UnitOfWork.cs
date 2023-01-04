using System.Threading.Tasks;
using Web_API_Pattern.Domain.Repositories;
using Web_API_Pattern.Persistence.Contexts;

namespace Web_API_Pattern.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}