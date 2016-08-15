using DomainObjects;
using System;

namespace PluginLibrary
{

    [PluginAttribute("CalculatorPlugin")]

    public class SquareOperator : IUnaryOperator
    {

        public string ArithmeticOperator
        {
            get { return "X^2"; }
        }

        public double PerformCalculation(string value)
        {
            Double numericValue = Double.Parse(value);
            return numericValue == 0 ? 0 : Math.Pow(numericValue, 2);
        }
    }

}
