using System;
using System.Collections.Generic;
using System.Linq;
using Web.DataAccess.Interfaces;
using Web.DataAccess.Repositories;
using Web.Models.Facilities;
using Web.ViewModels;

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

        public Facility CreateEmpty(EmptyFacilityViewModel emptyFacilityViewModel)
        {
            var facility = new Facility(Guid.NewGuid(), emptyFacilityViewModel.Name);

            unitOfWork.GetRepository<Facility>().Insert(facility);
            unitOfWork.Save();

            return facility;
        }

        public Facility GetFacility(Guid id)
        {
            var facility =
                unitOfWork.GetRepository<Facility>()
                    .Get(f => f.Id == id, includeProperties: "Components")
                    .FirstOrDefault();

            return facility;
        }
    }
}