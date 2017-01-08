using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Web.Models.Components;

namespace Web.Models.Facilities
{
    public class Facility
    {
        public Facility()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }

        public Facility(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Component> Components { get; set; } = new List<Component>();

        public void AddComponent(Component component)
        {
            // TODO: make method to check existence
            // TODO: create custom exception
            if (component != null && Components.All(c => c.Id != component.Id))
            {
                Components.Add(component);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}