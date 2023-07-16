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
    public class EmployeeManager : IEmployeeService
    {

        private readonly IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void TDelete(Employee t)
        {
           _employeeDal.Delete(t);
        }

        public Employee TGetById(int id)
        {
           return _employeeDal.GetById(id); 
        }

        public List<Employee> TGetList()
        {
            return _employeeDal.GetList();
        }

        public void TInsert(Employee t)
        {
           _employeeDal.Insert(t);
        }

        public void TUpdate(Employee t)
        {
            _employeeDal.Update(t);
        }
    }
}
