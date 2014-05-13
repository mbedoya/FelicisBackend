using BusinessManager.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWeb.Controllers
{
    public class ForbiddenFoodController : Controller
    {
        //
        // GET: /ForbiddenFood/
        public JsonResult Get()
        {
            return Json(ForbiddenFoodBO.GetAll(), JsonRequestBehavior.AllowGet);
        }

    }
}
