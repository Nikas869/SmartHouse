using System;
using System.Web.Mvc;
using Core.Services;

namespace Web.Controllers.Components
{
    public class SmoothSliderController : Controller
    {
        private readonly ComponentService componentService;

        public SmoothSliderController()
        {
            componentService = new ComponentService();
        }

        public ActionResult SetValue(Guid id, int value)
        {
            var result = componentService.SmoothSliderSetValue(id, value);

            if (!result)
            {
                return new HttpStatusCodeResult(500);
            }

            return new HttpStatusCodeResult(200);
        }
    }
}