using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/9 10:34:27
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.Entity
{
    public class Video
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Author { get; set; }

        public string Cover { get; set; }

        public string Content { get; set; }

        public string Address { get; set; }

        public DateTime CreateDate { get; set; }


    }
}
