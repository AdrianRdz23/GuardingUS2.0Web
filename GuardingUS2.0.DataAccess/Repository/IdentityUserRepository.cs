using GuardingUS2._0.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository
{
    public class IdentityUserRepository : Repository<IdentityUser>, IIdentityUserRepository
    {
        private readonly ApplicationDbContext _db;

        public IdentityUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(IdentityUser obj)
        {
            _db.IdentityUsers.Update(obj);
        }

    }
}
