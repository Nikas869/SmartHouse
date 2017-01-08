using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models.Enums;

namespace Web.Controllers
{
    public class ComponentsController : Controller
    {
        // TODO: add displaying list of components
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}