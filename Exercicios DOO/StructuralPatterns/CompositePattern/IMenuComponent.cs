using Exercicios_DOO.StructuralPatterns.BridgePattern;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.StructuralPatterns.CompositePattern
{
    public interface IMenuComponent
    {
        void Display();
        void Add(IMenuComponent component);
    }
}
