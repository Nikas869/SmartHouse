using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Core.Services;
using Core.ViewModels;

namespace Web.Controllers
{
    public class FacilitiesController : Controller
    {
        private readonly FacilitiesService facilitiesService;
        private readonly ComponentService componentService;

        public FacilitiesController(FacilitiesService facilitiesService, ComponentService componentService)
        {
            this.facilitiesService = facilitiesService;
            this.componentService = componentService;
        }

        // GET: Facilities
        public ActionResult Index()
        {
            ICollection<FacilityViewModel> facilities = facilitiesService.GetAllFacilities();

            return View(facilities);
        }

        [HttpPost]
        public ActionResult CreateEmpty(EmptyFacilityViewModel emptyFacilityViewModel)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_CreateEmptyFacility", emptyFacilityViewModel);
            }

            var id = facilitiesService.CreateEmpty(emptyFacilityViewModel);

            return Json(new { RedirectUrl = Url.Action("Details", new { id }) });
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

        public ActionResult DeleteComponent(Guid id, Guid facilityId)
        {
            componentService.DeleteComponent(id);

            return RedirectToAction("Details", new { id = facilityId });
        }
    }
}