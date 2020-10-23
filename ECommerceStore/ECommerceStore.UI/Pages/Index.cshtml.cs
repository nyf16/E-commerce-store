using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerceStore.Application.Products;
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
                     
        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            Products = new GetProducts(_ctx).Do();
        }
        
    }
}
