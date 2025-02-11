using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.StructuralPatterns.BridgePattern
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }
        public override void Draw()
        {
            Console.WriteLine("Desenhando um círculo.");
            Color.ApplyColor();
        }
    }
}
