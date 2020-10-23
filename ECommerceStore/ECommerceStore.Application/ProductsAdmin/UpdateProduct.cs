using ECommerceStore.Database;
using ECommerceStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceStore.Application.CreateProducts
{
    public class UpdateProduct
    {
        private ApplicationDbContext _context;

        public UpdateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel model)
        {            

            await _context.SaveChangesAsync();
        }

        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }
}
