using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
    }
}