using ExploringIdentity.Data;
using ExploringIdentity.Models;
using ExploringIdentity.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ExploringIdentity.Services
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AccountRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public  IEnumerable<Account> GetAccountAsync()
        {
            return  _applicationDbContext.Accounts;
        }

        public  IEnumerable<Account> GetByOwnerIdAsync(int Id)
        {
            return  _applicationDbContext.Accounts
                .Include(o => o.Owner)
                .Where(a => a.OwnerId == Id);
        }

    }
}
