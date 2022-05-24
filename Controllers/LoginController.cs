using Capstone_Project.Models;
using Capstone_Project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Capstone_Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()

        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.IsValid(userModel))
            {
                 return View("LoginSuccess", userModel);

            } else
            {
                return View("LoginFailure", userModel);
            }

        }
    }
}
