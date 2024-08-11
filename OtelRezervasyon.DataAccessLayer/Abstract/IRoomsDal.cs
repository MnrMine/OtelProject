using OtelRezervasyon.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.DataAccessLayer.Abstract
{
    public interface IRoomsDal : IGenericDal<Rooms>
    {
        int GetRoomCount();
    }
}
