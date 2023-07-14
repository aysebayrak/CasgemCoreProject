using PizzaPan.BussinesLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.BussinesLayer.Concrete
{
    public class TestimanialManager : ITestimanialService
    {

        private readonly ITestimanialDal _testimanialDal;

        public TestimanialManager(ITestimanialDal testimanialDal)
        {
            _testimanialDal = testimanialDal;   
        }

        public void TDelete(Testimanial t)
        {
            _testimanialDal.Delete(t);
        }

        public Testimanial TGetById(int id)
        {
            return _testimanialDal.GetById(id);
        }

        public List<Testimanial> TGetList()
        {
            return _testimanialDal.GetList();
        }

        public void TInsert(Testimanial t)
        {
            _testimanialDal.Insert(t);
        }

        public void TUpdate(Testimanial t)
        {
            _testimanialDal.Update(t);
        }
    }
}
