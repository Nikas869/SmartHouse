using System;
using Web.Models.Components.Interfaces;

namespace Web.Models.Components
{
    public class Switch : BaseComponent, ISwitchable
    {
        public Switch()
            : base(string.Empty)
        {
        }

        public Switch(string name, bool isOn) : base(name)
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