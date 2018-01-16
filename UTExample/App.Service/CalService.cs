using System;
using System.Collections.Generic;
using System.Text;
using App.BL;

namespace App.Service
{
    public class CalService : ICalService
    {
        private readonly ICalculatorBl _calculatorBl;
        public CalService(ICalculatorBl calculatorBl)
        {
            _calculatorBl = calculatorBl;
        }

        public int Add(string x, string y)
        {
            //Validation logic
            return _calculatorBl.Add(x, y);
        }

        public int Subtract(string x, string y)
        {
            //Validation logic
            return _calculatorBl.Subtract(x, y);
        }
    }
}
