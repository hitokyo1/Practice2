using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika2._3._3
{
    class Calculation
    {
        public string calculationLine = "";
        public string SetCalculationLine
        {
            set { calculationLine = value; }
        }
        public void SetLastSymbolCalculationLine(string plusSymbol)
        {
            calculationLine += plusSymbol;
        }
        public string GetCalculationLine
        {
            get { return calculationLine; }
        }
        public string GetLastSymbol()
        {
            calculationLine = calculationLine.Substring(calculationLine.Length - 1);
            return calculationLine;
        }
        public string DeleteLastSymbol()
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
            return calculationLine;
        }
    }
}