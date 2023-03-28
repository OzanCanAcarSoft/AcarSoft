using AcarSoft.Areas.Manager.Allowed;
using AcarSoft.Areas.Manager.Extension;
using AcarSoft.Areas.Manager.Models;
using Business;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;

namespace AcarSoft.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class LogInController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
		public IActionResult ManagerLogIn()
        {
            return View();
        }
		[HttpPost]
        public IActionResult ManagerLogIn(ManagerLogin user)
        {
            ManagerBs bs = new ManagerBs();
            Model.Entities.Manager manager = bs.LogIn(user.email, user.password);
            if (manager != null)
            {
                ViewBag.Manager = manager;
                HttpContext.Session.SetObject("LoggedManager", manager);
                List<Model.Entities.Manager> managers = bs.GetAll();
                ViewBag.Managers = managers;
                return View("~/Areas/Manager/Views/ManagerHome/Index.cshtml");
            }
            ViewBag.Manager = "Email or Password is wrong.";
            ViewBag.Alert = "danger";
            return View();
        }
    }
}
