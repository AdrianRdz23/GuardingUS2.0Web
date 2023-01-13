using GuardingUS2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository.IRepository
{
    public interface IApplicationUserRespository : IRepository<ApplicationUser>
    {
        void Update(ApplicationUser obj);
    }
}
