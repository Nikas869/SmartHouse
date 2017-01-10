using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Services;
using Core.ViewModels.Components;

namespace Web.Controllers.Components
{
    public class StepSliderController : Controller
    {
        private readonly ComponentService componentService = new ComponentService();

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("EditorTemplates/SmoothSliderViewModel");
        }

        [HttpPost]
        public ActionResult AddToFacility(StepSliderViewModel stepSliderViewModel, Guid facilityId)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("EditorTemplates/StepSliderViewModel", stepSliderViewModel);
            }

            //componentService.CreateStepSlider(stepSliderViewModel, facilityId);

            return RedirectToAction("Details", "Facilities", facilityId);
        }
    }
}