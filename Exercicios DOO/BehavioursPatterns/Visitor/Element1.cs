using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.Visitor
{
    public class Element1
    {
        public void Accept(IVisitor visitor) { visitor.Visit(this); }
    }
}
