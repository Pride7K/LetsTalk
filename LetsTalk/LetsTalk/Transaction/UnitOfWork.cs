using System.Threading;
using System.Threading.Tasks;
using LetsTalk.Data;

namespace LetsTalk.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task Commit(CancellationToken token)
        {
            await _context.SaveChangesAsync(cancellationToken:token);
        }

        public void RollBack()
        {

        }
    }
}