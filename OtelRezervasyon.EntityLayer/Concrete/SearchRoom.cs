using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.EntityLayer.Concrete
{
    public class SearchRoom
    {
        public int SearchRoomID { get; set; }

        [Column(TypeName = "Date")]
        public DateTime EntryDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        public int RoomsId { get; set; }
        public Rooms Room { get; set; }
    }
}
