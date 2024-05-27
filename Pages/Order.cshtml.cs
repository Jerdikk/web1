using web1.Data;
using web1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web1.Pages
{
    public class OrderModel : PageModel
    {
        private BakeryContext context;
        public OrderModel(BakeryContext context) =>
            this.context = context;
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Product Product { get; set; }
        public async Task OnGetAsync() =>
            Product = await context.Products.FindAsync(Id);
    }
}
