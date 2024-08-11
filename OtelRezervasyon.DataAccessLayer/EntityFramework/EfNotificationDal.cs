using OtelRezervasyon.DataAccessLayer.Abstract;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.DataAccessLayer.Repository;
using OtelRezervasyon.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        HotelContext context = new HotelContext();
        public List<Notification> GetListNotification()
        {
            var values = context.Notifications.OrderByDescending(x => x.Date).Take(3).ToList();
            return values;
        }
    }
}
