using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Core.ViewModels;
using DataAccess.Interfaces;
using DataAccess.Models.Facilities;
using DataAccess.Repositories;

namespace Core.Services
{
    public class FacilitiesService
    {
        private readonly IUnitOfWork unitOfWork;

        public FacilitiesService()
        {
            unitOfWork = new UnitOfWork();
        }

        public ICollection<FacilityViewModel> GetAllFacilities()
        {
            IList<Facility> facilities = unitOfWork.GetRepository<Facility>().Get(includeProperties: "Components");

            return Mapper.Map<IList<Facility>, List<FacilityViewModel>>(facilities);
        }

        public Guid CreateEmpty(EmptyFacilityViewModel emptyFacilityViewModel)
        {
            var id = Guid.NewGuid();
            var facility = new Facility(id, emptyFacilityViewModel.Name);

            unitOfWork.GetRepository<Facility>().Insert(facility);
            unitOfWork.Save();

            return id;
        }

        public FacilityViewModel GetFacility(Guid id)
        {
            var facility =
                unitOfWork.GetRepository<Facility>()
                    .Get(f => f.Id == id, includeProperties: "Components")
                    .FirstOrDefault();

            return Mapper.Map<Facility, FacilityViewModel>(facility);
        }
    }
}