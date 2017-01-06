using System.Collections.Generic;
using System.Web.Mvc;
using DataAccess.Entities.Facilities;
using Web.Services;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly FacilitiesService facilitiesService;

        public HomeController()
        {
            facilitiesService = new FacilitiesService();
        }

        public ActionResult Index()
        {
            IEnumerable<BaseFacility> facilities = facilitiesService.GetAllFacilities();

            return View(facilities);
        }
    }
}