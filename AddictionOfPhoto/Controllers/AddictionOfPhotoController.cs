using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddictionOfPhoto.BLL;
using AddictionOfPhoto.Entity;

namespace AddictionOfPhoto.Controllers
{
    public class AddictionOfPhotoController : Controller
    {
        private static Entity.AddictionOfPhotoContext db = new AddictionOfPhotoContext();


        private readonly BLL.Navigation navigationHelper = new BLL.Navigation(db);
        private readonly BLL.Gallery galleryHelper = new BLL.Gallery(db);
        private readonly BLL.Topic topicHelper = new BLL.Topic(db);
        private readonly BLL.Video videoHelper = new BLL.Video(db);

        //
        // GET: /API/

        //public ActionResult Index()
        //{
        //    AddictionOfPhotoContext db = new AddictionOfPhotoContext();

        //    var model = db.Gallery.FirstOrDefault();
        //    var topicGallery = db.TopicGallery.FirstOrDefault();



        //    ViewData["model"] = model;
        //    ViewData["topicGallery"] = topicGallery;
        //    return View();
        //}

        [HttpGet]
        public ActionResult GetHomeList(bool? isFresh, int fromId = 0, int count = 20)
        {
            var result = navigationHelper.GetHomeList(isFresh,fromId, count);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult GetResult()
        //{
        //    var result = navigationHelper.GetHomeList(0, 16);
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult GetGalleryType()
        {
            var result = galleryHelper.GetTypeList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetGalleryListByType(bool? isFresh, int typeId = 0, int fromId = 0, int count = 16)
        {
            var result = galleryHelper.GetGalleryByType(isFresh,typeId, fromId, count);

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetPicListByGallery(bool? isFresh, int galleryId, int fromId = 0, int count = 16)
        {
            var result = galleryHelper.GetPicListByGallery(isFresh,galleryId, fromId, count);
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetPic(int id)
        {
            var result = galleryHelper.GetPic(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetTopicList(bool? isFresh, int fromId = 0, int count=16)
        {
            var result = topicHelper.GetList(isFresh,fromId,count);
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetTopicInfo(int id)
        {
            var result = topicHelper.GetTopic(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetVideoList(bool? isFresh, int fromId = 0, int count = 16)
        {
            var result = videoHelper.GetList(isFresh, fromId, count);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetVideo(int id)
        {
            var result = videoHelper.GetVideo(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
