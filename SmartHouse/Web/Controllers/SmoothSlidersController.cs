using System;
using System.Net;
using System.Web.Mvc;
using Web.Models.Components;
using Web.Services;

namespace Web.Controllers
{
    public class SmoothSlidersController : Controller
    {
        private readonly ComponentService componentService = new ComponentService();

        // GET: SmoothSliders/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmoothSlider smoothSlider = componentService.GetSmoothSlider(id);
            if (smoothSlider == null)
            {
                return HttpNotFound();
            }
            return View(smoothSlider);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SmoothSliders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,MinValue,MaxValue")] SmoothSlider smoothSlider)
        {
            if (ModelState.IsValid)
            {
                componentService.CreateSmoothSlider(smoothSlider);
            }

            return View(smoothSlider);
        }
    }
}
