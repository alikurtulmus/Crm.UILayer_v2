using Crm.BusinessLayer.Abstract;
using Crm.DataAccessLayer.Abstract;
using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employee;

        public EmployeeManager(IEmployeeDal employee)
        {
            _employee = employee;
        }

        public void TDelete(Employee t)
        {
            _employee.Delete(t);
        }

        public Employee TGetByID(int id)
        {
            return _employee.GetByID(id);
        }

        public List<Employee> TGetListAll()
        {
            return _employee.GetListAll();
        }

        public void TInsert(Employee t)
        {
            _employee.Insert(t);
        }

        public void TUpdate(Employee t)
        {
            _employee.Update(t);
        }
    }
}
