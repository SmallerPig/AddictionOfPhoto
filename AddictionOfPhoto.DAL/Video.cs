using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/10 14:10:22
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.DAL
{
    public class Video
    {
        private Entity.AddictionOfPhotoContext dbContext;

        public Video(Entity.AddictionOfPhotoContext db)
        {
            this.dbContext = db;
        }

        public object GetList()
        {
            var result = from a in dbContext.Video
                select new {Id = a.Id, Titile = a.Title, Cover = a.Cover, Summary = a.Summary};
            return result.ToList();
        }

        public object GetVideo(int id)
        {
            return dbContext.Video.SingleOrDefault(item => item.Id == id);
        }

        public object GetList(int fromId, int count)
        {
            var result = from a in dbContext.Video
                         where fromId == 0 || a.Id < fromId
                         orderby a.Id descending
                         select new { Id = a.Id, Titile = a.Title, Cover = a.Cover, Summary = a.Summary };
            return result.Take(count).ToList();
        }

        public object GetList(int count)
        {
            return dbContext.Video.OrderByDescending(item => item.Id).Take(count);
        }
    }
}
