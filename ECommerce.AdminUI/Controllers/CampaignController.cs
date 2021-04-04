using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.AdminUI.Controllers
{
    public class CampaignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            ViewBag.activeMain = "campaign";
            ViewBag.active = "campaign-list";
            return View();
        }

        public IActionResult Manage()
        {
            ViewBag.activeMain = "campaign";
            ViewBag.active = "campaign-manage";
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
