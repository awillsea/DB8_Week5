using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    public class Calculator
    {
        public int Number { get; set; }

        public Calculator(int _number)
        {
            Number = _number;
        }

        public int Findfactorial()
        {
            // to find a factorial  

            int result = Number;

            for(int next = Number - 1; next >= 1; next--)
            {
                result = result * next;
            }
            return result;
        }
    }
}
