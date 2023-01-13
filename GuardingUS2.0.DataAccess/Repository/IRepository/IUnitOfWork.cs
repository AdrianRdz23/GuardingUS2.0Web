using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IHomeRepository Home { get; }
        INotificationRepository Notification { get; }
        IRoleRepository Role { get; }

        IApplicationUserRespository ApplicationUser { get; }
        IUserNotificationRepository UserNotification { get; }
        IVisitorRepository Visitor { get; }



        void Save();
    }
}
