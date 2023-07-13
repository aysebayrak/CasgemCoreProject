using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.DataAccessLayer.Repositories;
using PizzaPan.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAccessLayer.EntityFramework
{
    public class EfProductDal  : GenericRepository<Product>, IProductDal
    {
    }
}
