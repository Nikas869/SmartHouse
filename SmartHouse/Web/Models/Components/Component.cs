using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Models.Facilities;

namespace Web.Models.Components
{
    public abstract class Component
    {
        public Component()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }

        protected Component(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual Facility Facility { get; set; }
    }
}