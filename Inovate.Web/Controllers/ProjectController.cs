using Inovate.Web.Models;
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
            return View(ProjectViewModel.GenerateSampleData(10));
        }
        public ActionResult Project(int projectId)
        {
            return View(ProjectViewModel.GenerateSampleData(1).FirstOrDefault());
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