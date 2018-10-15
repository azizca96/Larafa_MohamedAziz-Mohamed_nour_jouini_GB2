using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class NotificationRepository : Repository<Notification>
    {
        public NotificationRepository(DbContext context) : base(context)
        {
        }

        /*public Notification FindNotificationByType(string type)
        {
            using (var dbContext = new GestionSyndicatDbContext())
            {
                var notificationRepository = new NotificationDAO(dbContext);
                return notificationRepository.FindByType(type);
            }
        }*/

    }
}