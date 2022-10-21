using System.Threading;
using System.Threading.Tasks;

namespace LetsTalk.Transaction
{
    public interface IUnitOfWork
    {
        Task Commit(CancellationToken token);

        void RollBack();
    }
}