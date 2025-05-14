//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace AgriV1.Controllers
//{
//    public class DashboardController : Controller
//    {
//        [Authorize(Roles = "Farmer")]
//        public IActionResult FarmerDashboard()
//        {
//            // Farmer-specific logic here
//            return View();
//        }

//        [Authorize(Roles = "Employee")]
//        public IActionResult EmployeeDashboard()
//        {
//            // Employee-specific logic here
//            return View();
//        }
//    }

//}

using AgriV1.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgriV1.Controllers
{
    //Author: Theo Walcot12
    //Accessable: https://stackoverflow.com/questions/31219704/how-to-connect-to-sql-server-using-asp-net-mvc-web-application
    //Date Accessed: 12 May 2025
    public class DashboardController : Controller
    {
        private readonly UserManager<AgriV1User> _userManager;

        public DashboardController(UserManager<AgriV1User> userManager)
        {
            _userManager = userManager;
        }

        [Authorize(Roles = "Farmer")]
        public IActionResult FarmerDashboard()
        {
            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult EmployeeDashboard()
        {
            return View();
        }


    }
}

