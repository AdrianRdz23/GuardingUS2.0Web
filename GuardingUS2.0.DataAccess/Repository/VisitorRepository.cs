using GuardingUS2._0.DataAccess.Repository.IRepository;
using GuardingUS2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository
{
    public class VisitorRepository : Repository<Visitor>, IVisitorRepository
    {
        private readonly ApplicationDbContext _db;

        public VisitorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Visitor obj)
        {
            _db.Visitors.Update(obj);
        }
    }
}
