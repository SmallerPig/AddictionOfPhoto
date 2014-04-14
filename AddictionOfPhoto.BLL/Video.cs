using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/10 14:11:04
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.BLL
{
    public class Video
    {
        private DAL.Video helper;

        public Video(Entity.AddictionOfPhotoContext db)
        {
            helper = new DAL.Video(db);
        }


        public object GetList(bool? isFresh, int fromId, int count)
        {
            if (isFresh != null && isFresh == true)
            {
                return helper.GetList(fromId, count);
            }
            return helper.GetList(count);
        }



        public object GetVideo(int id)
        {
            return helper.GetVideo(id);
        }
    }
}
