using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities.Components
{
    public abstract class BaseComponent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public BaseComponent()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }

        protected BaseComponent(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}