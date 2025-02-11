using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.ChainOfResponsability
{
    public class BillHandler : DocumentHandler
    {
        public override void Handle(string document)
        {
            if (document == "Bill")
            {
                Console.WriteLine("Processing Bill...");
            }
            else if (_next != null)
            {
                _next.Handle(document);
            }
            else
            {
                Console.WriteLine("Cannot process " + document);
            }
        }
    }
}
