using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository.IRepository
{
    public interface IIdentityRoleRepository : IRepository<IdentityRole>
    {
        void Update(IdentityRole obj);
    }
}
