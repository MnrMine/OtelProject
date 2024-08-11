using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.DataAccessLayer.Abstract;
using OtelRezervasyon.EntityLayer.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.BusinessLayer.Concrete
{
    public class RoomsManager : IRoomService
    {
        private readonly IRoomsDal _roomsDal;

        public RoomsManager(IRoomsDal roomsDal)
        {
            _roomsDal = roomsDal;
        }

        public void TDelete(int id)
        {
            _roomsDal.Delete(id);
        }

        public Rooms TGetById(int id)
        {
            return _roomsDal.GetById(id);
        }

        public List<Rooms> TGetListAll()
        {
            return _roomsDal.GetListAll();
        }

        public int TGetRoomCount()
        {
            return _roomsDal.GetRoomCount();
        }

        public void TInsert(Rooms entity)
        {
            _roomsDal.Insert(entity);
        }

        

        public void TUpdate(Rooms entity)
        {
            _roomsDal.Update(entity);
        }

        

      

      
    }
}
