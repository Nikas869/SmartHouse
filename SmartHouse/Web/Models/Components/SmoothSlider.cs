using System;
using Web.Models.Components.Interfaces;

namespace Web.Models.Components
{
    public class SmoothSlider : BaseComponent, ISlidable
    {
        public SmoothSlider()
               : base(string.Empty)
        {
        }

        public SmoothSlider(string name, int minValue, int maxValue)
            : base(name)
        {
            // TODO: create custom exception
            if (MinValue > MaxValue)
            {
                throw new ArgumentException();
            }
            MinValue = minValue;
            MaxValue = maxValue;
            Value = minValue;
        }

        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public int Value { get; set; }
        

        public void SetValue(int value)
        {            
            // TODO: create custom exception
            if (value > MinValue && value < MaxValue)
            {
                Value = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}