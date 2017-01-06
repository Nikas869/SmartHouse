using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using DataAccess.Entities.Components;

namespace DataAccess.Entities.Facilities
{
    public class BaseFacility
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<BaseComponent> Components { get; set; } = new List<BaseComponent>(1);

        public BaseFacility()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }

        public BaseFacility(Guid id, string name)
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