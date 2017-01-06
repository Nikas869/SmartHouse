using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Entities.Components;

namespace DataAccess.Entities.Facilities
{
    public class BaseFacility
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public List<BaseComponent> Components { get; set; } = new List<BaseComponent>(1);

        protected BaseFacility(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddComponent(BaseComponent component)
        {
            // TODO: make method to check existence
            if (component != null && Components.All(c => c.Id != component.Id))
            {
                Components.Add(component);
            }
            // TODO: create custom exception
            else
            {
                throw new ArgumentException();
            }
        }
    }
}