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
    public class RoleManager : IRoleService
    {
        IRoleDal _role;

        public RoleManager(IRoleDal role)
        {
            _role = role;
        }

        public void TDelete(Role t)
        {
            _role.Delete(t);
        }

        public Role TGetByID(int id)
        {
            return _role.GetByID(id);
        }

        public List<Role> TGetListAll()
        {
            return _role.GetListAll();
        }

        public void TInsert(Role t)
        {
            _role.Insert(t);
        }

        public void TUpdate(Role t)
        {
            _role.Update(t);
        }
    }
}


