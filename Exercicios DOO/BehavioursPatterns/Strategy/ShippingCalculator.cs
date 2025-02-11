using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.Strategy
{
    public class ShippingCalculator
    {
        private IShipping _shipping;
        public ShippingCalculator(IShipping shipping) { _shipping = shipping; }
        public void SetStrategy(IShipping shipping) { _shipping = shipping; }
        public decimal Calculate(decimal weight) => _shipping.Calculate(weight);
    }
}