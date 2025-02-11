using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.Strategy
{
    public class ExpressShipping : IShipping
    { 
        public decimal Calculate(decimal weight) => weight * 0.25m; 
    }
}
