using BusinessManager.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWeb.Controllers
{
    public class BreedController : Controller
    {
        //
        // GET: /Breed/      
        public JsonResult Get()
        {
            return Json(BreedBO.GetAll(), JsonRequestBehavior.AllowGet);
        }
       
        public JsonResult Search(string text)
        {
            return Json(BreedBO.Search(text), JsonRequestBehavior.AllowGet);
        }

    }
}
