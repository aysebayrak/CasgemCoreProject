using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public DateTime CreationDate { get; set; }

        public DateTime LastDate { get; set; }

        public int NumberUsers{ get; set; }

    }
}
