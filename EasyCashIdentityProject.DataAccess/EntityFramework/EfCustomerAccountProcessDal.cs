using EasyCashIdentityProject.DataAccess.Abstract;
using EasyCashIdentityProject.DataAccess.Repositories;
using EasyCashIdentityProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccess.EntityFramework
{
    public class EfCustomerAccountProcessDal:GenericRepository<CustomerAccountProcess>,ICustomerAccountProcessDal
    {
    }
}
