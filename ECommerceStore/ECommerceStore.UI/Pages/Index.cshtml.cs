using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerceStore.Application.CreateProducts;
using ECommerceStore.Application.GetProducts;
using ECommerceStore.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceStore.UI.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _ctx;


        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public Application.CreateProducts.CreateProduct.ProductViewModel Product { get; set; }

        public IEnumerable<Application.GetProducts.ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            Products = new GetProducts(_ctx).Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_ctx).Do(Product);

            return RedirectToPage("Index");
        }
    }
}
