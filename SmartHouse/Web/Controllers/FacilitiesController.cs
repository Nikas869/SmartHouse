using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models.Facilities;
using Web.Services;

namespace Web.Controllers
{
    public class FacilitiesController : Controller
    {
        private readonly FacilitiesService facilitiesService;

        public FacilitiesController()
        {
            facilitiesService = new FacilitiesService();
        }

        // GET: Facilities
        public ActionResult Index()
        {
            IEnumerable<Facility> facilities = facilitiesService.GetAllFacilities();

            return View(facilities);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Facility facility)
        {
            if (ModelState.IsValid)
            {
                facilitiesService.Create(facility);
                return RedirectToAction("Index");
            }

            return View(facility);
        }
    }
}