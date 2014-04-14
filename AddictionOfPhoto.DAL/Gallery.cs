using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/10 9:22:43
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.DAL
{
    public class Gallery
    {
        private Entity.AddictionOfPhotoContext dbContext;
        
        public Gallery(Entity.AddictionOfPhotoContext db)
        {
            this.dbContext = db;
        }

        public IList<Entity.GalleryType> GetTypeList()
        {
            return dbContext.GalleryType.ToList();
        }

        public object GetGalleryByType(int typeId, int fromId, int count)
        {
            var result = from a in dbContext.Gallery
                         where (typeId==0||a.Type ==typeId) &&  (fromId == 0 || a.Id < fromId )
                         orderby a.Id descending
                         select a;
            return result.Take(count).ToList();

        }



        public object GetPicListByGallery(int galleryId, int fromId, int count)
        {
            var result = from a in dbContext.GalleryPic
                where a.GalleryId == galleryId
                join p in dbContext.Pics on a.PicId equals p.Id
                where fromId == 0 || p.Id < fromId
                select p;
            return result.OrderByDescending(item=>item.Id).Take(count).ToList();
        }

        public object GetPicListByGallery(int galleryId, int count)
        {
            var result = from a in dbContext.GalleryPic
                         where a.GalleryId == galleryId
                         join p in dbContext.Pics on a.PicId equals p.Id
                         select p;
            return result.Take(count).ToList();
        }




        public object GetPic(int id)
        {
            return dbContext.Pics.SingleOrDefault(item => item.Id == id);
        }

        public object GetGalleryByType(int typeId, int count)
        {
            return dbContext.Gallery
                .Where(item =>typeId==0|| item.Type == typeId)
                .OrderByDescending(item=>item.Id)
                .Take(count)
                .ToList();
        }
    }
}
