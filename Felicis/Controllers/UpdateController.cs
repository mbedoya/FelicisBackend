using BusinessManager.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWeb.Controllers
{
    public class UpdateController : Controller
    {
        //
        // GET: /Update/

        public JsonResult Get()
        {
            return Json(UpdateBO.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Search(int updatesApplied = 0)
        {
            return Json(UpdateBO.Search(updatesApplied), JsonRequestBehavior.AllowGet);
        }

    }
}
