using EasyCashIdentityProject.DataAccess.Abstract;
using EasyCashIdentityProject.DataAccess.Concrete;
using EasyCashIdentityProject.DataAccess.Repositories;
using EasyCashIdentityProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;


namespace EasyCashIdentityProject.DataAccess.EntityFramework
{
    public class EfCustomerAccountProcessDal : GenericRepository<CustomerAccountProcess>, ICustomerAccountProcessDal
    {
        List<CustomerAccountProcess> ICustomerAccountProcessDal.MyLastProcess(int id)
        {
            using var context = new Context();
            var aliciGondereciOlunanIslemler = context.CustomerAccountProcesses.Include(a=>a.SenderCustomer).Include(c=>c.ReceiverCustomer).ThenInclude(d=>d.AppUser).Where(x => x.ReceiverID == id || x.SenderID == id).ToList();
            return aliciGondereciOlunanIslemler;
        }

    }
}
