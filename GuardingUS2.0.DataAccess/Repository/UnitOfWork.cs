using GuardingUS2._0.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Home = new HomeRepository(_db);
            Notification = new NotificationRepository(_db);
            Role = new RoleRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            UserNotification = new UserNotificationRepository(_db);
            Visitor = new VisitorRepository(_db);

        }

        public IHomeRepository Home { get; private set; }
        public INotificationRepository Notification { get; private set; }
        public IRoleRepository Role { get; private set; }
        public IApplicationUserRespository ApplicationUser { get; private set; }
        public IUserNotificationRepository UserNotification { get; private set; }
        public IVisitorRepository Visitor { get; private set; }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
