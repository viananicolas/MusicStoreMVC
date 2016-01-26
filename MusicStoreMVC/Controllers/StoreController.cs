﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreMVC.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        // GET: Store/Browse
        public string Browse(string genre)
        {
            var message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
            //return View();
        }
        // GET: Store/Details
        public ActionResult Details()
        {
            return View();
        }
    }
}