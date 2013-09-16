using Inovate.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inovate.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new HomeIndexViewModel();
            viewModel.FeaturedProjects = ProjectViewModel.GenerateSampleData(3);
            viewModel.RecentProjects = ProjectViewModel.GenerateSampleData(3);
            return View(viewModel);
        }

        public ActionResult TopProjects()
        {
            return View(ProjectViewModel.GenerateSampleData(5));
        }
    }
}