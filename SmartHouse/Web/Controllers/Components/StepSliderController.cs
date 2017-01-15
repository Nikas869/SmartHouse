using System;
using System.Web.Mvc;
using Core.Services;

namespace Web.Controllers.Components
{
    public class StepSliderController : Controller
    {
        private readonly ComponentService componentService;

        public StepSliderController(ComponentService componentService)
        {
            this.componentService = componentService;
        }

        public ActionResult IncreaseValue(Guid id)
        {
            var result = componentService.StepSliderIncreaseValue(id);

            if (!result)
            {
                return new HttpStatusCodeResult(500);
            }

            return new HttpStatusCodeResult(200);
        }

        public ActionResult ReduceValue(Guid id)
        {
            var result = componentService.StepSliderReduceValue(id);

            if (!result)
            {
                return new HttpStatusCodeResult(500);
            }

            return new HttpStatusCodeResult(200);
        }
    }
}