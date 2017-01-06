using System;
using DataAccess.Entities.Components.Interfaces;

namespace DataAccess.Entities.Components
{
    public class StepSlider : BaseComponent, IStepable
    {
        public int MinValue { get; }

        public int MaxValue { get; }

        public int Value { get; private set; }

        public int Step { get; }

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