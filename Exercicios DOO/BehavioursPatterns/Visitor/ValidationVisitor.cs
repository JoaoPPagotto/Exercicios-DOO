using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercicios_DOO.BehavioursPatterns.Visitor
{
    public class ValidationVisitor : IVisitor
    {
        public void Visit(Element1 element) { Console.WriteLine("Validating Element1..."); }
        public void Visit(Element2 element) { Console.WriteLine("Validating Element2..."); }
    }
}
