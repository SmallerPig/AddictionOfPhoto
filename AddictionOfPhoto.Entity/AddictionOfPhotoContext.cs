using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;

/*==========================================================
*作者：SmallerPig
*时间：2014/4/9 15:39:54
*版权所有:无锡睿阅数字科技有限公司
============================================================*/

namespace AddictionOfPhoto.Entity
{
    public class AddictionOfPhotoContext : DbContext
    {
        public AddictionOfPhotoContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<AddictionOfPhotoContext>(null);
        }

        //public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Entity.Navigation> Navigation { get; set; }
        public DbSet<Entity.Gallery> Gallery { get; set; }
        public DbSet<Entity.Video> Video { get; set; }
        public DbSet<Entity.Topic> Topic { get; set; }
        public DbSet<Entity.Panoramic> Panoramic { get; set; }
        public DbSet<Entity.GalleryPic> GalleryPic { get; set; }
        public DbSet<Entity.GalleryType> GalleryType { get; set; }
        public DbSet<Entity.TopicGallery> TopicGallery { get; set; }
        public DbSet<Entity.TopicVideo> TopicVideo { get; set; }
        public DbSet<Entity.Pic> Pics { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //取消默认复数表名的设置
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
