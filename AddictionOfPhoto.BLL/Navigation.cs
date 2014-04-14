using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/9 15:38:32
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.BLL
{

    public class Navigation 
    {
        private DAL.Navigation helper;

        public Navigation(Entity.AddictionOfPhotoContext dbContext)
        {
            helper = new DAL.Navigation(dbContext);
        }

        public IList<Entity.Navigation> GetHomeList(bool? isFresh, int fromId, int count)
        {
            if (isFresh != null && isFresh == true)
            {
                return helper.GetHomeList(fromId, count);
            }
            return helper.GetHomeList(count);
        }

    }
}
