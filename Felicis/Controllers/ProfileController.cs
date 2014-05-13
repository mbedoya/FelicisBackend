using BusinessManager.Business;
using BusinessManager.Models;
using BusinessManager.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWeb.Controllers
{
    public class ProfileController : Controller
    {
        // GET: /Profile/      
        public JsonResult Get(string email, string password)
        {
            return Json(ProfileBO.Get(email, password), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Check(string email)
        {
            return Json(ProfileBO.Get(email), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Post(ProfileDataModel profile)
        {
            try
            {
                return Json(ProfileBO.Create(profile), JsonRequestBehavior.AllowGet);
            }
            catch (AccountExistsException ex)
            {
                return Json(new { errorMessage = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;               
            }

           
        }
    }
}