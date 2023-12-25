using EasyCashIdentityProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.Business.Abstract
{
    public interface ICustomerAccountProcessService:IGenericService<CustomerAccountProcess>
    {
        List<CustomerAccountProcess> MyLastProcessService(int id);

    }
}
