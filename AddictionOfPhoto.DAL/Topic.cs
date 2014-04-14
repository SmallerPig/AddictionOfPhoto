using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/10 11:44:57
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.DAL
{
    public class Topic
    {
        private Entity.AddictionOfPhotoContext dbContext;

        public Topic(Entity.AddictionOfPhotoContext db)
        {
            this.dbContext = db;
        }

        public object GetList(int fromId,int count)
        {
            var result = from a in dbContext.Topic
                         where fromId==0 || a.Id< fromId
                orderby a.Id descending
                select new {Id = a.Id, Titile = a.Title, Cover = a.Cover, Summary = a.Summary};
            return result.Take(count).ToList();
        }

        public object GetTopic(int id)
        {
            Entity.Topic topic = dbContext.Topic.SingleOrDefault(item => item.Id == id);
            var gallery = from g in dbContext.Gallery    
                join   topicgallery in dbContext.TopicGallery on   g.Id equals topicgallery.GalleryId
                where topic.Id == topicgallery.TopicId
                select g;

            var video = from topicVideo in dbContext.TopicVideo
                where topic.Id == topicVideo.TopicId
                join v in dbContext.Video on topicVideo.VideoId equals v.Id
                select v;

                //join topicgallery in dbContext.TopicGallery on topic.Id equals topicgallery.TopicId
                //join gallery in dbContext.Gallery on topicgallery.GalleryId equals gallery.Id
                //join topicVideo in dbContext.TopicVideo on topic.Id equals topicVideo.TopicId
                //join video in dbContext.Video on topicVideo.VideoId equals video.Id
                //select new {Topic = topic, Gallery = gallery, Video = video};
            return new {Topic=topic,Gallery = gallery,Video = video};
        }

        public object GetList(int count)
        {
            return dbContext.Topic.OrderByDescending(item => item.Id).Take(count);
        }
    }
}
