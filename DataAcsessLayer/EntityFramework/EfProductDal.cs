using Microsoft.EntityFrameworkCore;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.DataAccessLayer.Repositories;
using PizzaPan.DataAcsessLayer.Concrete;
using PizzaPan.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategory()
        {
            using var context = new Context();
            return context.Products.Include(x => x.category).ToList();
        }
    }
}
