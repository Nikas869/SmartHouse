using System;

namespace DataAccess.Entities.Components
{
    public abstract class BaseComponent
    {
        public Guid Id { get; }

        public string Name { get; }

        protected BaseComponent(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}