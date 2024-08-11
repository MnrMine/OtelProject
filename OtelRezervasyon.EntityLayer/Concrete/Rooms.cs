using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.EntityLayer.Concrete
{
    public class Rooms
    {
        public int RoomsId { get; set; }
        public string CoverImageUrl { get; set; }
        public string RoomName { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int Bed { get; set; }
        public int Square { get; set; }
        public bool Available { get; set; }
        public string ReservationStatus { get; set; } = "None";
    }
}
