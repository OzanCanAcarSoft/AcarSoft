using AcarSoft.Areas.Client.Models;
using AcarSoft.Areas.Manager.Extension;
using Business;
using Microsoft.AspNetCore.Mvc;

namespace AcarSoft.Areas.Client.Controllers
{
	public class LogIn : Controller
	{
		[Area("Client")]
		public IActionResult ClientLogIn()
		{
			return View();
		}

		[HttpPost]
		[Area("Client")]
        public IActionResult ClientLogIn(ClientLogIn client)
        {
            ClientBs bs = new ClientBs();
            Model.Entities.Client client1 = bs.LogIn(client.email, client.password, "Purchases");
            if (client1 != null)
            {
                HttpContext.Session.SetObject("LoggedClient", client1);
                ViewBag.LoggedClient = client1;
                return View("~/Areas/Client/Views/ClientHome/Index.cshtml", client1);
            }
            ViewBag.LogInFail = "Email or Password is wrong.";
            return View();
        }
    }
}
