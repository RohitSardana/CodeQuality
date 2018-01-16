using System;
using System.Collections.Generic;
using System.Text;

namespace App.BL
{
    public class CalculatorBl : ICalculatorBl
    {
        public int Add(string x, string y)
        {
            //Apply business logic
            return Int32.Parse(x) + Int32.Parse(y);
        }

        public int Subtract(string x, string y)
        {
            //Apply business logic
            return Int32.Parse(x) - Int32.Parse(y);
        }
    }
}
