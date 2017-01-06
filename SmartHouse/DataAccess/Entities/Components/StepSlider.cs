using System;
using DataAccess.Entities.Components.Interfaces;

namespace DataAccess.Entities.Components
{
    public class StepSlider : BaseComponent, IStepable
    {
        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public int Value { get; set; }

        public int Step { get; set; }

        public StepSlider() : base(Guid.NewGuid(), string.Empty) { }

        public StepSlider(Guid id, string name, int minValue, int maxValue, int step) : base(id, name)
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