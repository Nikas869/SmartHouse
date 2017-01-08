using System.Collections.Generic;
using Web.DataAccess.Interfaces;
using Web.DataAccess.Repositories;
using Web.Models.Facilities;

namespace Web.Services
{
    public class FacilitiesService
    {
        private readonly IUnitOfWork unitOfWork;

        public FacilitiesService()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<Facility> GetAllFacilities()
        {
            return unitOfWork.GetRepository<Facility>().Get(includeProperties: "Components");
        }

        public void Create(Facility facility)
        {
            unitOfWork.GetRepository<Facility>().Insert(facility);
        }
    }
}