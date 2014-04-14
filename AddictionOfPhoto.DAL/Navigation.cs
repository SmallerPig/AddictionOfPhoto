using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/9 15:44:01
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.DAL
{

    public class Navigation
    {
        private Entity.AddictionOfPhotoContext dbContext;

        public Navigation(Entity.AddictionOfPhotoContext db)
        {
            dbContext = db;
        }

        public IList<Entity.Navigation> GetHomeList(int fromId,int count)
        {
            var result = from a in dbContext.Navigation
                         where fromId == 0 || a.Id < fromId
                         orderby a.Id descending
                         select a;
            return result.Take(count).ToList();
        }


        public IList<Entity.Navigation> GetHomeList(int count)
        {
            return dbContext.Navigation.OrderByDescending(item => item.Id).Take(count).ToList();
        }



    }
}
