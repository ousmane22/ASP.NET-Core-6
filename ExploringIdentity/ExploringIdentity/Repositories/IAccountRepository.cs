using ExploringIdentity.Models;

namespace ExploringIdentity.Repositories
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccountAsync();
        IEnumerable<Account> GetByOwnerIdAsync(int Id);
    }
}
