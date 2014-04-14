using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/10 11:44:44
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.BLL
{
    public class Topic
    {
        private DAL.Topic helper;

        public Topic(Entity.AddictionOfPhotoContext db)
        {
            helper = new DAL.Topic(db);
        }




        public object GetList(bool? isFresh, int fromId = 0, int count = 16)
        {
            if (isFresh != null && isFresh == true)
            {
                return helper.GetList(fromId, count);
            }
            return helper.GetList(count);
        }

        public object GetTopic(int id)
        {
            return helper.GetTopic(id);
        }
    }
}
