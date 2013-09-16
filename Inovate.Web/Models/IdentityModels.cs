using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Configuration;

namespace Inovate.Web.Models
{
    public class ApplicationUser : User
    {
        public ApplicationUser()
        {
            Random rd = new Random();
            CurrentCredit = rd.Next(10, 150);
        }
        public decimal CurrentCredit { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContextWithCustomUser<ApplicationUser>
    {
       
    }
}