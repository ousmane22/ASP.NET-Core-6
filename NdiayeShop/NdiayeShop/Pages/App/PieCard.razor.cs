using NdiayeShop.Models;
using Microsoft.AspNetCore.Components;

namespace NdiayeShop.Pages.App
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
