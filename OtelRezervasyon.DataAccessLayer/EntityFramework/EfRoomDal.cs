using OtelRezervasyon.DataAccessLayer.Abstract;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.DataAccessLayer.Repository;
using OtelRezervasyon.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.DataAccessLayer.EntityFramework
{
    public class EfRoomDal : GenericRepository<Rooms>, IRoomsDal
    {
        HotelContext context = new HotelContext();

        public int GetRoomCount()
        {
            return context.Roomses.Count();
        }


    }
}
