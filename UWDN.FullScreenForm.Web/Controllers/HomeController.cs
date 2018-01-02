using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UWDN.FullScreenForm.Web.Models;
using UWDN.FullScreenForm.Web.Services;

namespace UWDN.FullScreenForm.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
        public IActionResult Contact([FromForm] Contact contact)
        {
			// todo:  validation
			new ContactService().Add(contact);

			var contactList = new ContactService().ListAll();

			return View(contactList);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
