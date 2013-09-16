using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inovate.Web.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Project/
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Project( int projectId)
        {
            return View();
        }
        public ActionResult CreateProject()
        {
            return View();
        }
        public ActionResult MakeAContribution(int projectId, float amount)
        {
            return View();
        }

        
	}
}