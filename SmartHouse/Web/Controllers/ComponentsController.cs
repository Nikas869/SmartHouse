using System;
using System.Web.Mvc;
using Core.Services;
using Core.ViewModels.Components;

namespace Web.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly ComponentService componentService;

        public ComponentsController()
        {
            componentService = new ComponentService();
        }

        public ActionResult CreateComponent(Guid redirectId)
        {
            var componentTypes = componentService.GetComponentTypes();
            ViewBag.RedirectId = redirectId;

            return PartialView("_CreateComponent", componentTypes);
        }

        [Route("Switch")]
        [HttpGet]
        public ActionResult CreateSwitch(Guid redirectId)
        {
            ViewBag.RedirectId = redirectId;

            return View("EditorTemplates/SwitchViewModel", new SwitchViewModel());
        }

        [Route("Switch")]
        [HttpPost]
        public ActionResult CreateSwitch(SwitchViewModel switchViewModel, Guid facilityId)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("EditorTemplates/SwitchViewModel", switchViewModel);
            }

            componentService.CreateSwitch(switchViewModel, facilityId);

            return RedirectToAction("Details", "Facilities", new { Id = facilityId });
        }
        
        [HttpGet]
        public ActionResult CreateSmoothSlider(Guid redirectId)
        {
            ViewBag.RedirectId = redirectId;

            return View("EditorTemplates/SmoothSliderViewModel", new SmoothSliderViewModel());
        }
        
        [HttpPost]
        public ActionResult CreateSmoothSlider(SmoothSliderViewModel smoothSliderViewModel, Guid facilityId)
        {
            if (!ModelState.IsValid)
            {
                return View("EditorTemplates/SmoothSliderViewModel", smoothSliderViewModel);
            }

            componentService.CreateSmoothSlider(smoothSliderViewModel, facilityId);

            return RedirectToAction("Details", "Facilities", new { Id = facilityId });
        }

        [HttpGet]
        public ActionResult CreateStepSlider(Guid redirectId)
        {
            ViewBag.RedirectId = redirectId;

            return View("EditorTemplates/StepSliderViewModel", new StepSliderViewModel());
        }

        [HttpPost]
        public ActionResult CreateStepSlider(StepSliderViewModel stepSliderViewModel, Guid facilityId)
        {
            if (!ModelState.IsValid)
            {
                return View("EditorTemplates/StepSliderViewModel", stepSliderViewModel);
            }

            componentService.CreateStepSlider(stepSliderViewModel, facilityId);

            return RedirectToAction("Details", "Facilities", new { Id = facilityId });
        }
    }
}