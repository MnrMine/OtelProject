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
    public class GalleryManager : IGalleryService
    {
        private readonly IGalleryDal _GalleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _GalleryDal = galleryDal;
        }

        public void TDelete(int id)
        {
            _GalleryDal.Delete(id);
        }

        public Gallery TGetById(int id)
        {
            return _GalleryDal.GetById(id);
        }

        public List<Gallery> TGetListAll()
        {
            return _GalleryDal.GetListAll();
        }

        public void TInsert(Gallery entity)
        {
            _GalleryDal.Insert(entity);
        }

        public void TUpdate(Gallery entity)
        {
            _GalleryDal.Update(entity);
        }
    }
}
