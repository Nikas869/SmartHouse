using System.Web.Mvc;
using Web.Services;

namespace Web.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly ComponentService componentService;

        public ComponentsController()
        {
            componentService = new ComponentService();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}