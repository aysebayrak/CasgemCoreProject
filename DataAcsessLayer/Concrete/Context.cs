using Microsoft.EntityFrameworkCore;
using PizzaPan.EntityLayer.Concrate;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAcsessLayer.Concrete
{
    public class Context: DbContext
    { 
       protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-D19MH5E\\SQLEXPRESS;initial catalog=CasgemDbPizzaPan;integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimanial> Testimanials { get; set; }



    }
}
