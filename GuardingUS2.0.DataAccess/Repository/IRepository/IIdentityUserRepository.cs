using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository.IRepository
{
    public interface IIdentityUserRepository : IRepository<IdentityUser>
    {
        void Update(IdentityUser obj);
    }
}
