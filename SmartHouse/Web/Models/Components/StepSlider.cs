using System;
using Web.Models.Components.Interfaces;

namespace Web.Models.Components
{
    public class StepSlider : BaseComponent, IStepable
    {
        public StepSlider()
            : base(string.Empty)
        {
        }
        
        public StepSlider(string name, int minValue, int maxValue, int step) : base(name)
        {
            // TODO: create custom exception
            if (MinValue > MaxValue)
            {
                throw new ArgumentException();
            }
            if (Step > MaxValue - MinValue)
            {
                throw new ArgumentException();
            }
            MinValue = minValue;
            MaxValue = maxValue;
            Step = step;
            Value = MinValue;
        }

        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Value { get; set; }
        public int Step { get; set; }

        public void Increase()
        {
            // TODO: create custom exception
            if (Value + Step > MaxValue)
            {
                throw new ArgumentException();
            }
            Value += Step;
        }

        public void Reduce()
        {
            // TODO: create custom exception
            if (MinValue > Value + Step)
            {
                throw new ArgumentException();
            }
            Value -= Step;
        }
    }
}