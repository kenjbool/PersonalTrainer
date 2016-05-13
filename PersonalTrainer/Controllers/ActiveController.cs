using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalTrainer.Controllers
{
    public class ActiveController : Controller
    {
        //
        // GET: /Active/

        public ActionResult Begin()
        {
            return RedirectToAction("Begin");
        }

    }
}
