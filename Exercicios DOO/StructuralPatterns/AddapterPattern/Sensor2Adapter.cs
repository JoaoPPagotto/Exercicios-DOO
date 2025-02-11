using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.StructuralPatterns.AddapterPattern
{
    public class Sensor2Adapter : ITemperatureSensor
    {
        private Sensor2 _sensor2 = new Sensor2();
        public double ReadTemperature() => _sensor2.ObtenerTemperaturaEnCentigrados();
    }
}
