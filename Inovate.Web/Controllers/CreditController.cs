using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inovate.Web.Controllers
{
    public class CreditController : Controller
    {
        //
        // GET: /Credit/
        public ActionResult MyCredit()
        {
            return View();
        }

        public ActionResult ProfessionsMenaging()
        {
            return View();
        }

        public ActionResult MarginManaging()
        {
            return View();
        }
	}
}