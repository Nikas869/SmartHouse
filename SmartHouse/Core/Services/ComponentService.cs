using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using Core.ViewModels.Components;
using DataAccess.Interfaces;
using DataAccess.Models.Components;
using DataAccess.Models.Facilities;
using DataAccess.Repositories;

namespace Core.Services
{
    public class ComponentService
    {
        private readonly IUnitOfWork unitOfWork;

        public ComponentService()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public SmoothSlider GetSmoothSlider(Guid? id)
        {
            var component = unitOfWork.GetRepository<SmoothSlider>().GetById(id);
            return component;
        }

        public ICollection<Component> GetAllUnusedComponents()
        {
            ICollection<Component> unusedComponents = unitOfWork.GetRepository<Component>().Get(c => c.Facility == null).ToList();

            return unusedComponents;
        }

        public Component GetById(Guid componentId)
        {
            var component = unitOfWork.GetRepository<Component>().GetById(componentId);

            return component;
        }

        public List<SelectListItem> GetComponentTypes()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            string[] types = ConfigurationManager.AppSettings["componentTypes"].Split(';');
            foreach (var type in types)
            {
                SelectListItem item = new SelectListItem
                {
                    Value = type.Split(',')[0],
                    Text = type.Split(',')[1]
                };
                listItems.Add(item);
            }

            return listItems;
        }

        #region Create component methods

        public void CreateSwitch(SwitchViewModel switchViewModel, Guid facilityId)
        {
            Guid id = Guid.NewGuid();
            var switchComponent = new Switch(
                id, 
                switchViewModel.Name, 
                switchViewModel.IsOn);
            unitOfWork.GetRepository<Switch>().Insert(switchComponent);

            var facility = unitOfWork.GetRepository<Facility>().GetById(facilityId);
            facility.AddComponent(switchComponent);
            unitOfWork.GetRepository<Facility>().Update(facility);

            unitOfWork.Save();
        }

        public void CreateSmoothSlider(SmoothSliderViewModel smoothSliderViewModel, Guid facilityId)
        {
            Guid id = Guid.NewGuid();
            var slider = new SmoothSlider(
                id, 
                smoothSliderViewModel.Name, 
                smoothSliderViewModel.MinValue, 
                smoothSliderViewModel.MaxValue);
            unitOfWork.GetRepository<SmoothSlider>().Insert(slider);

            var facility = unitOfWork.GetRepository<Facility>().GetById(facilityId);
            facility.AddComponent(slider);
            unitOfWork.GetRepository<Facility>().Update(facility);

            unitOfWork.Save();
        }

        #endregion

        public void DeleteComponent(Guid id)
        {
            var component = unitOfWork.GetRepository<Component>().GetById(id);
            unitOfWork.GetRepository<Component>().Delete(component);

            unitOfWork.Save();
        }

        public void ToggleSwitch(Guid id)
        {
            var switchComponent = unitOfWork.GetRepository<Switch>().GetById(id);
            switchComponent.Toggle();
            unitOfWork.GetRepository<Switch>().Update(switchComponent);
            unitOfWork.Save();
        }

        public void SmoothSliderSetValue(Guid id, int value)
        {
            var smoothSlider = unitOfWork.GetRepository<SmoothSlider>().GetById(id);
            smoothSlider.SetValue(value);
            unitOfWork.GetRepository<SmoothSlider>().Update(smoothSlider);
            unitOfWork.Save();
        }
    }
}