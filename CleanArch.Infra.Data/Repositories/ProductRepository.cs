using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.MVC.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public ApplicationDbContext _ctx;


        public ProductRepository(ApplicationDbContext ctx) {
            _ctx=ctx;
        }
        public IEnumerable<Product> getProducts()
        {
            return _ctx.Products;
        }
    }
}
