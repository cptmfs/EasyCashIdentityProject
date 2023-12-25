using EasyCashIdentityProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.Business.Abstract
{
    public interface ICustomerAccountService:IGenericService<CustomerAccount>
    {
        public List<CustomerAccount> GetCustomerAccountsListService(int id);

    }
}
