using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.StructuralPatterns.FacadePattern
{
    public class Projector
    {
        public void On() => Console.WriteLine("Projetor ligado.");
        public void Off() => Console.WriteLine("Projetor desligado.");
    }
}
