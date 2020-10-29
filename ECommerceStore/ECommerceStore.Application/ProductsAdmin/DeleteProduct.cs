﻿using ECommerceStore.Database;
using ECommerceStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceStore.Application.CreateProducts
{
    public class DeleteProduct
    {
        private ApplicationDbContext _context;

        public DeleteProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(int id)
        {
            var Product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(Product);
            await _context.SaveChangesAsync();
        }
    }
}