using System;
using DataAccess.Entities.Components.Interfaces;

namespace DataAccess.Entities.Components
{
    public class Switch : BaseComponent, ISwitchable
    {
        public bool IsOn { get; private set; }

        public Switch(Guid id, string name, bool isOn) : base(id, name)
        {
            IsOn = isOn;
        }

        public void Toggle()
        {
            IsOn = !IsOn;
        }
    }
}