using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Services;

namespace Web.Controllers.Components
{
    public class SwitchController : Controller
    {
        private readonly ComponentService componentService;

        public SwitchController()
        {
            componentService = new ComponentService();
        }

        public ActionResult ToggleSwitch(Guid id)
        {
            componentService.ToggleSwitch(id);
            return null;
        }
    }
}