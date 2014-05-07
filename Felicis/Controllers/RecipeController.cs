using BusinessManager.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWeb.Controllers
{
    public class RecipeController : Controller
    {
        //
        // GET: /Recipe/

        public JsonResult Get()
        {
            return Json(RecipeBO.GetAll(), JsonRequestBehavior.AllowGet);
        }

    }
}
