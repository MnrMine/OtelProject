using OtelRezervasyon.DataAccessLayer.Abstract;
using OtelRezervasyon.DataAccessLayer.Repository;
using OtelRezervasyon.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {

    }
}
