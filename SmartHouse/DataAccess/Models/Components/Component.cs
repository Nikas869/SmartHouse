using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Models.Facilities;

namespace DataAccess.Models.Components
{
    public abstract class Component
    {
        public Component()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }

        protected Component(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual Facility Facility { get; set; }
    }
}