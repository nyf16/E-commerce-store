﻿using ECommerceStore.Database;
using ECommerceStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceStore.Application.Products
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;

        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Do(int id, string Name, string Description)
        {
            _context.Products.Add(new Product
            {
                Id = id,
                Name = Name,
                Description = Description
            });
        }
    }
}
