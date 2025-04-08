using BooklyProject.Context;
using BooklyProject.Entities;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooklyProject.Controllers
{
    [Authorize]

    public class CategoryController : Controller
    {
        // GET: Category
        //etkileşim sınıfı
            BooklyContext context = new BooklyContext();
        public ActionResult Index()
        {
            var values = context.Categories.ToList();
            return View(values);
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category model)
        {
            context.Categories.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var value = context.Categories.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult EditCategory(Category model)
        {

            var value = context.Categories.Find(model.CategoryId);
            value.CategoryName = model.CategoryName;
            value.ImageUrl = model.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}