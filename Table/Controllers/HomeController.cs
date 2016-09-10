﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Table.Models;

namespace Table.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Partial = "TaskRows";
                return RedirectToAction("Index", "Task");
        }

        public ActionResult MoveToPage(string page)
        {
            if(page == "Tasks")
            {
                return RedirectToAction("Index", "Task");
            }
            return View(page);
        }

        public ActionResult Login()
        {
            return PartialView("LoginWindow");
        }

        public ActionResult SendFeedback(string name, string email, string feedback)
        {
            return RedirectToAction("Index", "Task");
        }
    }
}