using ExploringIdentity.Data;
using ExploringIdentity.Models;
using ExploringIdentity.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ExploringIdentity.Services
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OwnerRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Owner> GetOwnerAsync()
        {
            return  _applicationDbContext.Owners;
        }

        public Owner GetOwnerByIdAsync(int Id)
        {
           return _applicationDbContext.Owners.FirstOrDefault(o => o.ID ==  Id);
        }
    }
}
