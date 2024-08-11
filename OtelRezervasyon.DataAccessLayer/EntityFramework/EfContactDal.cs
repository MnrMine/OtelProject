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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        private readonly HotelContext _context;

      

        public EfContactDal(HotelContext context)
        {
            _context = context;
        }

        public List<Contact> GetMessageListByAdmin(string p)
        {
            var values = _context.Contacts.Where(x => x.Email == p).OrderByDescending(x => x.Date).ToList();
            return values;
        }
    }
}
