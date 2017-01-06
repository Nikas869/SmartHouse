using System.Collections.Generic;
using DataAccess.Entities.Facilities;
using DataAccess.Interfaces;
using DataAccess.Repositories;

namespace Web.Services
{
    public class FacilitiesService
    {
        private readonly IUnitOfWork unitOfWork;

        public FacilitiesService()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<BaseFacility> GetAllFacilities()
        {
            return unitOfWork.GetRepository<BaseFacility>().Get(includeProperties: "Components");
        }
    }
}