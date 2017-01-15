using System;
using System.Web.Mvc;
using Core.Services;

namespace Web.Controllers.Components
{
    public class SwitchController : Controller
    {
        private readonly ComponentService componentService;

        public SwitchController(ComponentService componentService)
        {
            this.componentService = componentService;
        }

        public ActionResult ToggleSwitch(Guid id)
        {
            componentService.ToggleSwitch(id);
            return null;
        }
    }
}