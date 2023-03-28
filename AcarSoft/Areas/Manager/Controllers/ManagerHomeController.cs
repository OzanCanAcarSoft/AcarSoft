using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AcarSoft.Areas.Manager.Extension;
using Model.Entities;
using Business;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.IO;
using AcarSoft.Areas.Manager.Models;
using Infrastructure.Helpers;

namespace AcarSoft.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class ManagerHomeController : Controller
	{
		ManagerBs bs = new ManagerBs();
		public IActionResult Index()
		{
            Model.Entities.Manager manager = HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");
            List<Model.Entities.Manager> managers = bs.GetAll();
            ViewBag.Managers = managers;
            ViewBag.Manager = manager;
            return View();
		}

		public IActionResult Projects()
		{
			Model.Entities.Manager manager = HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");
			ViewBag.Manager = manager;
			return View();
		}

        public IActionResult AboutUs()
        {
            Model.Entities.Manager manager = HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");
            ViewBag.Manager = manager;
            return View();
        }

        public IActionResult Contact()
        {
            Model.Entities.Manager manager = HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");
            ViewBag.Manager = manager;
            return View();
        }
		public IActionResult Edit()
		{
			Model.Entities.Manager manager = HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");
			ViewBag.Manager = manager;
			ViewBag.EditingManager = HttpContext.Session.GetObject<Model.Entities.Manager>("EditingManager");
			return View();
		}


		[HttpPost]
		public IActionResult Select(int id)
		{
			Model.Entities.Manager manager = bs.GetById(id);
			HttpContext.Session.SetObject("EditingManager", manager);
			return Json(new { success = true });
		}

		[HttpPost]
		public IActionResult UploadPhoto(IFormCollection data)
		{
			IFormFile file = data.Files[0];
			if (file == null)
			{
				return Json(new { success = false, message = "Please select a file." });
			}
			if (!file.ContentType.Contains("image/"))
			{
				return Json(new { success = false, message = "Please select an image file." });
			}
			Model.Entities.Manager editingmanager = HttpContext.Session.GetObject<Model.Entities.Manager>("EditingManager");
			string randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(file.FileName));
			string filePath = "/Pictures/" + randomFileName;
			string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/" + filePath);

			using (FileStream fs = new FileStream(uploadPath, FileMode.Create))
			{
				file.CopyTo(fs);
			}
			ViewBag.NewPhotoPath = uploadPath;
			return Json(new { success = true, photoPath = randomFileName });
		}

		[HttpPost]
		public IActionResult Modify(ModifyManager modifyingmanager)
		{
			
			List<Model.Entities.Manager> manList = bs.GetAll();
			foreach (var item in manList)
			{
				if (item.Email == modifyingmanager.Email)
				{
					return Json(new { success = false, message = "E-mail already exists!" });
				}
			}
			Model.Entities.Manager editingmanager = HttpContext.Session.GetObject<Model.Entities.Manager>("EditingManager");
			int id = editingmanager.Id;
			editingmanager.Id = id;
			editingmanager.FullName = modifyingmanager.FullName;
			editingmanager.Email = modifyingmanager.Email;
			editingmanager.Password = modifyingmanager.Password;
			editingmanager.PhotoPath = modifyingmanager.PhotoPath;
			bs.Update(editingmanager);
			return Json(new { success = true});

		}

		[HttpPost]
		public IActionResult ManagerPhoto(IFormCollection data)
		{
			IFormFile file = data.Files[0];
			if (file == null)
			{
				return Json(new { success = false, message = "Please select a file." });
			}
			if (!file.ContentType.Contains("image/"))
			{
				return Json(new { success = false, message = "Please select an image file." });
			}
			Model.Entities.Manager editingmanager = HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");
			string randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(file.FileName));
			string filePath = "/Pictures/" + randomFileName;
			string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/" + filePath);

			using (FileStream fs = new FileStream(uploadPath, FileMode.Create))
			{
				file.CopyTo(fs);
			}
			ViewBag.NewPhotoPath = uploadPath;
			return Json(new { success = true, photoPath = randomFileName });
		}

		[HttpPost]
		public IActionResult ManagerModify(ModifyManager modifyingmanager)
		{

			List<Model.Entities.Manager> manList = bs.GetAll();
			foreach (var item in manList)
			{
				if (item.Email == modifyingmanager.Email)
				{
					return Json(new { success = false, message = "E-mail already exists!" });
				}
			}
			Model.Entities.Manager editingmanager = HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");
			int id = editingmanager.Id;
			editingmanager.Id = id;
			editingmanager.FullName = modifyingmanager.FullName;
			editingmanager.Email = modifyingmanager.Email;
			editingmanager.Password = modifyingmanager.Password;
			editingmanager.PhotoPath = modifyingmanager.PhotoPath;
			bs.Update(editingmanager);
			return Json(new { success = true });

		}

		public IActionResult EditPage()
		{
			Model.Entities.Manager manager = HttpContext.Session.GetObject<Model.Entities.Manager>("LoggedManager");
			ViewBag.Manager = manager;
			return View(manager);
		}

	}
}
