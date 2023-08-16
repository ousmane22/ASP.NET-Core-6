using ExploringIdentity.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExploringIdentity.Controllers
{
    public class OwnerController : Controller
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
        public ViewResult List()
        {
           var owners = _ownerRepository.GetOwnerAsync();
            return View(owners);
        }
    }
}
