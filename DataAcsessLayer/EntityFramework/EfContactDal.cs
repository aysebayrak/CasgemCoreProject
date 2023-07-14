using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.DataAccessLayer.Repositories;
using PizzaPan.DataAcsessLayer.Concrete;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public List<Contact> GetContactBySubjectWithTesekkur()
        {
            using var context = new Context();
            var values = context.Contacts.Where(x =>x.Subject =="Teşekkürler").ToList();
            return values;
        }
    }
}
