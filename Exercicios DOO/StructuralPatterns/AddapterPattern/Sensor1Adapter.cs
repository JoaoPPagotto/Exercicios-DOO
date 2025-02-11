using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.StructuralPatterns.AddapterPattern
{
    public class Sensor1Adapter : ITemperatureSensor
    {
        private Sensor1 _sensor1 = new Sensor1();
        public double ReadTemperature() => _sensor1.GetTemperatureInCelsius();
    }
}
