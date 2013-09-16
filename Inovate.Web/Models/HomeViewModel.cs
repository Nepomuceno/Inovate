using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inovate.Web.Models
{
    public class HomeIndexViewModel
    {
        public List<ProjectViewModel> FeaturedProjects { get; set; }
        public List<ProjectViewModel> RecentProjects { get; set; }
    }
}