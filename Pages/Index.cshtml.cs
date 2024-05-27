using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using web1.Data;
using web1.Models;
using Microsoft.EntityFrameworkCore;

namespace web1.Pages;

public class IndexModel : PageModel
{
    private readonly BakeryContext context;

    //private readonly ILogger<IndexModel> _logger;

    public IndexModel(BakeryContext context) =>
       this.context = context;

    /*public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }*/

    public List<Product> Products { get; set; } = new();
    public async Task OnGetAsync() =>
        Products = await context.Products.ToListAsync();


}
