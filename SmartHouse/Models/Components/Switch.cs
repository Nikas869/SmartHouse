using System;
using Models.Components.Interfaces;

namespace DataAccess.Models.Components
{
    public class Switch : Component, ISwitchable
    {
        public Switch()
            : base(Guid.NewGuid(), string.Empty)
        {
        }

        public Switch(Guid id, string name, bool isOn)
            : base(id, name)
        {
            IsOn = isOn;
        }

        public bool IsOn { get; set; }

        public void Toggle()
        {
            IsOn = !IsOn;
        }
    }
}