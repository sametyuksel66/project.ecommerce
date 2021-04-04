//using ECommerce.Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
//using ECommerce.BLL.Abstract;

namespace ECommerce.AdminUI.Controllers
{
    //deneme amacli eklendi.
    public class ImageController : Controller
    {
        //private IImageService _imageService;

        //public ImageController(IImageService imageService)
        //{
        //    _imageService = imageService;
        //}


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(Image addImage, List<IFormFile> Road)
        //{ //dosya olarak eklenen gorseli varbinary tipine donusturup HexaDecimal kod olarak sakliyor. 
        //    foreach (var item in Road)
        //    {
        //        if (item.Length>0)
        //        {
        //            using (var stream = new MemoryStream())
        //            {
        //                await item.CopyToAsync(stream);
        //                addImage.Road = stream.ToArray();
        //            }
        //        }
        //    }
        //    _imageService.Add(addImage);


        //    return View();
        //}




        public IActionResult List()
        {
            ViewBag.activeMain = "image";
            ViewBag.active = "image-list";
            return View();
        }


        public IActionResult Manage()
        {
            ViewBag.activeMain = "image";
            ViewBag.active = "image-manage";
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
