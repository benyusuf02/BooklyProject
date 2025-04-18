﻿using BooklyProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooklyProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        BooklyContext context= new BooklyContext();
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminLayoutNavbar()
        {
            var userName = Session["currentUser"].ToString();

            ViewBag.nameSurname = context.Admins.Where(x => x.FirstName == userName).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();



            //ViewBag.imageUrl = context.Admins.Where(x => x.UserName == userName).Select(x => x.ImageUrl).FirstOrDefault();



            return PartialView();
        }
    }
}