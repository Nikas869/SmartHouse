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
            componentService.SmoothSliderSetValue(id, value);
            return null;
        }
    }
}