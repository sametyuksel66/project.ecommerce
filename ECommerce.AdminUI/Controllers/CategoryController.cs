using ECommerce.AdminUI.DTOs;
using ECommerce.AdminUI.Helper;
using ECommerce.Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.AdminUI.Controllers
{
    public class CategoryController : Controller
    {

        private IApi _api;
        public CategoryController(IApi api)
        {
            _api = api;
        }





        [HttpGet]
        public async Task<IActionResult> List()
        {
            ViewBag.activeMain = "category";
            ViewBag.active = "category-list";

            List<GetCategoryDTO> getCategories = new List<GetCategoryDTO>();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Category/get");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                getCategories = JsonConvert.DeserializeObject<List<GetCategoryDTO>>(result);
            }
            return View(getCategories);
        }





        [HttpGet]
        public async Task<IActionResult> Manage()
        {
            ViewBag.activeMain = "category";
            ViewBag.active = "category-manage";
            List<GetCategoryDTO> getCategories = new List<GetCategoryDTO>();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Category/get");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                getCategories = JsonConvert.DeserializeObject<List<GetCategoryDTO>>(result);
            }

            return View(getCategories);
        }





        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ViewBag.activeMain = "category";
            ViewBag.active = "category-add";
            addCategoryDTO model = new addCategoryDTO();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Category/get");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                model.categoryLists  = JsonConvert.DeserializeObject<List<GetCategoryDTO>>(result);
            }
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Add(addCategoryDTO addCategory)
        {
            AddForCategoryDTO createModel = new AddForCategoryDTO();
            createModel.ParentCategoryId = Convert.ToInt32(addCategory.ParentCategoryId);
            createModel.Name = addCategory.name;
            HttpClient client = _api.Initial();
            var content = new StringContent(JsonConvert.SerializeObject(createModel).ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await client.PostAsync("api/Category/add", content);
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                return RedirectToAction("Manage");
            }
            return View(addCategory);
        }





        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            updateCategoryDTO model = new updateCategoryDTO();
            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Category/id?id="+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
              var convertmodel = JsonConvert.DeserializeObject<convertUpdateCategoryDTO>(result);
                model = convertmodel.data;
                             
            }
            HttpResponseMessage responseMessage2 = await client.GetAsync("api/Category/get");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var result = responseMessage2.Content.ReadAsStringAsync().Result;
                model.categoryLists = JsonConvert.DeserializeObject<List<GetCategoryDTO>>(result);
            }
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Update(updateCategoryDTO updateCategory)
        {
            Category updateModel = new Category();
            updateModel.ParentCategoryId = updateCategory.ParentCategoryId;
            updateModel.Name = updateCategory.name;
            updateModel.ID = updateCategory.id;
            HttpClient client = _api.Initial();
            var content = new StringContent(JsonConvert.SerializeObject(updateModel).ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await client.PostAsync("api/Category/Update", content);
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                return RedirectToAction("Manage");
            }
            return View(updateCategory);
        }




               
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            Category deleteItem = new Category();
            deleteItem.ID = id;
            var json = JsonConvert.SerializeObject(deleteItem);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = _api.Initial();
            HttpResponseMessage responseMessage = await client.PostAsync("api/Category/delete", data);
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
            }
            return RedirectToAction("Manage");
        }
    }
}
