using System;
using DataAccess.Entities.Components.Interfaces;

namespace DataAccess.Entities.Components
{
    public class SmoothSlider : BaseComponent, ISlidable
    {
        public int MinValue { get; }

        public int MaxValue { get; }

        public int Value { get; private set; }

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