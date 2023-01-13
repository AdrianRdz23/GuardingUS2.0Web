using GuardingUS2._0.DataAccess.Repository.IRepository;
using GuardingUS2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository
{
    public class UserNotificationRepository : Repository<UserNotification>, IUserNotificationRepository
    {
        private readonly ApplicationDbContext _db;

        public UserNotificationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


    }
}
