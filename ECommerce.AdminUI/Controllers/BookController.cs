using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.AdminUI.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            ViewBag.activeMain = "book";
            ViewBag.active = "book-list";

            return View();
        }

        [HttpGet]
        public IActionResult Manage()
        {
            ViewBag.activeMain = "book";
            ViewBag.active = "book-manage";
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }


        public IActionResult Delete()
        {
            return View();
        }


        public IActionResult Update()
        {
            return View();
        }
    }
}
