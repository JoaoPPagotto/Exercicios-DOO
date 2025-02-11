using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.StructuralPatterns.AddapterPattern
{
    public class Sensor3Adapter : ITemperatureSensor
    {
        private Sensor3 _sensor3 = new Sensor3();
        public double ReadTemperature() => _sensor3.FetchTempC();
    }
}
