using OtelRezervasyon.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.BusinessLayer.Abstracts
{
    public interface INotificationService : IGenericService<Notification>
    {
        List<Notification> TGetListNotification();
    }
}
