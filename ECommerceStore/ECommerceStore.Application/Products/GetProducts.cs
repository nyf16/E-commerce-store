using ECommerceStore.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceStore.Application.GetProducts
{
    public class GetProducts
    {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<ProductViewModel> Do() =>
            _ctx.Products.ToList().Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Value = $"$ {x.Value.ToString("N2")}", // 2200.50 => 2,200.50 => $ 2,200.50
            });
    }

    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}



