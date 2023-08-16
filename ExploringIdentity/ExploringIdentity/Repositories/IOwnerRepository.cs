using ExploringIdentity.Models;

namespace ExploringIdentity.Repositories
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetOwnerAsync();
        Owner GetOwnerByIdAsync(int Id);

    }
}
