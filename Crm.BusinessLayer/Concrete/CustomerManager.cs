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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customer;

        public CustomerManager(ICustomerDal customer)
        {
            _customer = customer;
        }

        public void TDelete(Customer t)
        {
            _customer.Delete(t);
        }

        public Customer TGetByID(int id)
        {
            return _customer.GetByID(id);
        }

        public List<Customer> TGetListAll()
        {
            return _customer.GetListAll();
        }

        public void TInsert(Customer t)
        {
            _customer.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customer.Update(t);
        }
    }
}
