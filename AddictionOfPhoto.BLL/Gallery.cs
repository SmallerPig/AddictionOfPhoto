using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/10 9:22:30
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.BLL
{
    public class Gallery
    {
        private DAL.Gallery helper;

        public Gallery(Entity.AddictionOfPhotoContext dbContext)
        {
            helper = new DAL.Gallery(dbContext);
        }


        public IList<Entity.GalleryType> GetTypeList()
        {
            return helper.GetTypeList();
        }

        public object GetGalleryByType(bool? isFresh, int typeId, int fromId = 0, int count = 16)
        {
            if (isFresh != null && isFresh == true)
            {
                return helper.GetGalleryByType(typeId, fromId, count);
            }
            return helper.GetGalleryByType(typeId, count);

        }

        public object GetPicListByGallery(bool? isFresh,int galleryId, int fromId, int count)
        {
            if (isFresh != null && isFresh == true)
            {
                return helper.GetPicListByGallery(galleryId, fromId, count);
            }
            return helper.GetPicListByGallery(galleryId, count);
        }

        public object GetPic(int id)
        {
            return helper.GetPic(id);
        }
    }
}
