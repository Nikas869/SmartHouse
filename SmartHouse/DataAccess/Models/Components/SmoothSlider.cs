using System;
using DataAccess.Models.Components.Interfaces;

namespace DataAccess.Models.Components
{
    public class SmoothSlider : Component, ISlidable
    {
        public SmoothSlider()
               : base(Guid.NewGuid(), string.Empty)
        {
        }

        public SmoothSlider(Guid id, string name, int minValue, int maxValue)
            : base(id, name)
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
