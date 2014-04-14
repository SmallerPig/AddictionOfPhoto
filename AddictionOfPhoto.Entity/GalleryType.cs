using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/9 10:40:22
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.Entity
{
    public class GalleryType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int OrderIndex { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
