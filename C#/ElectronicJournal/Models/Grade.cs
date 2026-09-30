using System;

namespace ElectronicJournal.Models
{
    public readonly struct Grade
    {
        public int Value { get; }

        public Grade(int value)
        {
            if (value < 1 || value > 5)
            {
                throw new ArgumentException("ќценка должна быть от 1 до 5.");
            }
            Value = value;
        }
    }
}
