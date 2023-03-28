using AcarSoft.Models;
using Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace AcarSoft.Controllers
{
    public class HomeController : Controller
    {
        ManagerBs bs = new ManagerBs();
        ProductBs bsp = new ProductBs();
        public IActionResult Index()
        {
            List<Model.Entities.Manager> managers = new List<Model.Entities.Manager>();
            managers = bs.GetAll();
            return View(managers);
        }
        public IActionResult Projects()
        {
            List<Model.Entities.Product> products= new List<Model.Entities.Product>();
            products = bsp.GetAll();
            return View(products);
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}
