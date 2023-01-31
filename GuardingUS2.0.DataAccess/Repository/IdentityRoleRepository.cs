using GuardingUS2._0.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository
{
    public class IdentityRoleRepository : Repository<IdentityRole>, IIdentityRoleRepository
    {
        private readonly ApplicationDbContext _db;

        public IdentityRoleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(IdentityRole obj)
        {
            _db.IdentityRoles.Update(obj);
        }
    }
}
