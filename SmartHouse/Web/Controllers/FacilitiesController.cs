using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Models.Facilities;
using Web.Services;
using Web.ViewModels;

namespace Web.Controllers
{
    public class FacilitiesController : Controller
    {
        private readonly FacilitiesService facilitiesService;
        private readonly ComponentService componentService;

        public FacilitiesController()
        {
            facilitiesService = new FacilitiesService();
            componentService = new ComponentService();
        }

        // GET: Facilities
        public ActionResult Index()
        {
            IEnumerable<Facility> facilities = facilitiesService.GetAllFacilities();

            return View(facilities);
        }

        [HttpPost]
        public ActionResult CreateEmpty(EmptyFacilityViewModel emptyFacilityViewModel)
        {
            var facility = facilitiesService.CreateEmpty(emptyFacilityViewModel);

            return RedirectToAction("Details", facility);
        }

        [HttpGet]
        public ActionResult Details(Guid id)
        {
            var facility = facilitiesService.GetFacility(id);

            if (facility == null)
            {
                return new HttpNotFoundResult();
            }

            return View(facility);
        }
    }
}