using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerClientValidation.Controllers
{
    public class ErrorHandlingsController : Controller
    {
        // GET: ErrorHandlings
        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult BadRequest()
        {
            return View();
        }

        //UnAuthorized
    }
}