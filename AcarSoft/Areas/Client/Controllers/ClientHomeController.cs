using AcarSoft.Areas.Manager.Extension;
using Business;
using Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Http;
using System.IO;
using AcarSoft.Areas.Client.Models;

namespace AcarSoft.Areas.Client.Controllers
{
    [Area("Client")]
    public class ClientHomeController : Controller
	{
		PurchaseBs purbs = new PurchaseBs();
		ProductBs probs = new ProductBs();
		ClientBs clibs = new ClientBs();
		public IActionResult Index()
		{
			Model.Entities.Client client = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
			ViewBag.LoggedClient = client;
			return View();
		}
		public IActionResult Projects()
		{
            Model.Entities.Client client = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
            ViewBag.LoggedClient = client;
			ProductBs bs = new ProductBs();
			List<Product> products = bs.GetAll();
            return View(products);
		}
		[HttpPost]
		public IActionResult buy(int productId, int selectedValue)
		{
            PurchaseBs bs = new PurchaseBs();
            Model.Entities.Client client = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
			List<Purchase> purchases = (List<Purchase>)client.Purchases;
            foreach (var item in purchases)
			{
				if (item.ClientId == client.Id)
				{
					if (item.ProductId == productId)
					{
						DateTime time = item.PurchaseDate;
						time.AddMonths(item.PurchaseDuration);
						return Json(new { success = false, message = "You already have this product! expire time is" + time});
					}
				}
            }

			Model.Entities.Purchase clientPurchase= new Model.Entities.Purchase();
			clientPurchase.ProductId = productId;
			clientPurchase.PurchaseDate = DateTime.Now;
			clientPurchase.ClientId = client.Id;
			clientPurchase.PurchaseDuration = selectedValue;
			clientPurchase.Product= probs.GetById(productId);
			purbs.Insert(clientPurchase);
            return Json(new { success = true });
        }
		public IActionResult Contact()
		{
			Model.Entities.Client client = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
			ViewBag.LoggedClient = client;
			return View();
		}
		public IActionResult AboutUs()
		{
			Model.Entities.Client client = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
			ViewBag.LoggedClient = client;
			return View();
		}

		public IActionResult Profile()
		{
            Model.Entities.Client client = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
            ViewBag.LoggedClient = client;
            return View(client);
		}
		[HttpPost]
		public IActionResult ClientPhoto(IFormCollection data)
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
			Model.Entities.Client editingclient = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
			string randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(file.FileName));
			string filePath = "/Pictures/" + randomFileName;
			string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/" + filePath);

			using (FileStream fs = new FileStream(uploadPath, FileMode.Create))
			{
				file.CopyTo(fs);
			}
			return Json(new { success = true, photoPath = randomFileName });
		}

		[HttpPost]
		public IActionResult ClientModify(ModifyClient modifyClient)
		{
			List<Model.Entities.Client> clientList = clibs.GetAll();
			foreach (var item in clientList)
			{
				if (item.Email == modifyClient.Email)
				{
					return Json(new { success = false, message = "E-mail already exists!" });
				}
			}
			Model.Entities.Client editingclient = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
			int id = editingclient.Id;
			editingclient.Id = id;
			editingclient.FullName = modifyClient.FullName;
			editingclient.Email = modifyClient.Email;
			editingclient.Password = modifyClient.Password;
			editingclient.PhotoPath = modifyClient.PhotoPath;
			clibs.Update(editingclient);
			return Json(new { success = true });
		}

		public IActionResult MyProducts()
		{
			Model.Entities.Client client = HttpContext.Session.GetObject<Model.Entities.Client>("LoggedClient");
			ViewBag.LoggedClient = client;
			List<Model.Entities.Product> products = probs.GetAll();
			ICollection<Model.Entities.Purchase> purchases = client.Purchases;
			foreach (var purchase in purchases)
			{
				purchase.Product = probs.GetById(purchase.ProductId);
			}
			ClientPurchases clientPurchases= new ClientPurchases();
			clientPurchases.products = new List<Model.Entities.Product>();
            clientPurchases.purchases = new List<Model.Entities.Purchase>();
            foreach (var product in products)
			{
				foreach(var purchase in purchases)
				{
					if(product.Id==purchase.ProductId)
					{ 
						clientPurchases.products.Add(purchase.Product);
						clientPurchases.purchases.Add(purchase);
					}
				}
			}
			return View(clientPurchases);
		}

	}
}
