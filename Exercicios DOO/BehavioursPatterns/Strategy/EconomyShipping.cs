using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.Strategy
{
    public class EconomyShipping : IShipping
    { 
        public decimal Calculate(decimal weight) => weight * 0.1m; 
    }
}
