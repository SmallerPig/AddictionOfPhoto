using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/9 10:05:22
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.Entity
{
    public class Gallery
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Type { get; set; }

        public string Cover { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
