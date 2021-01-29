using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Csharp
{
    public struct WeatherObservation
    {
        public DateTime RecordedAt { get; init; }
        public decimal TemperatureInCelsius { get; init; }
        public decimal PressureInMillibars { get; init; }

        public override string ToString() =>
            $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
            $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
    }
    class InitSetters
    {

        public void Tryouts()
        {
            var now = new WeatherObservation
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };

            // Error! CS8852.
            //now.TemperatureInCelsius = 18;

        }
    }
}
