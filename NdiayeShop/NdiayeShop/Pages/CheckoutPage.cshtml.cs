using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NdiayeShop.Pages
{
    public class CheckoutPageModel : PageModel
    {
        public Order Order { get; set; }
        public void OnGet()
        {
        }
    }
}
