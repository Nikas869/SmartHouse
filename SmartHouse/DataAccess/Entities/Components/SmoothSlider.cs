using System;
using DataAccess.Entities.Components.Interfaces;

namespace DataAccess.Entities.Components
{
    public class SmoothSlider : BaseComponent, ISlidable
    {
        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public int Value { get; set; }

        public SmoothSlider() : base(Guid.NewGuid(), string.Empty) { }

        public SmoothSlider(Guid id, string name, int minValue, int maxValue) : base(id, name)
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

        public void SetValue(int value)
        {
            if (value > MinValue && value < MaxValue)
            {
                Value = value;
            }
            // TODO: create custom exception
            else
            {
                throw new ArgumentException();
            }
        }
    }
}