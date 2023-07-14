using PizzaPan.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.BussinesLayer.Abstract
{
    public interface IProductService :IGenericeService<Product>
    {
        public List<Product> TGetProductsWithCategory();
    }
}
