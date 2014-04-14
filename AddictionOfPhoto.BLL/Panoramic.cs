using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/11 13:42:38
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.BLL
{
    public class Panoramic
    {
        private DAL.Panoramic helper;

        public Panoramic(Entity.AddictionOfPhotoContext db)
        {
            helper = new DAL.Panoramic(db);
        }

    }
}
