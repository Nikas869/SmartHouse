using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models.Components
{
    public abstract class BaseComponent
    {
        public BaseComponent()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }

        protected BaseComponent(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}