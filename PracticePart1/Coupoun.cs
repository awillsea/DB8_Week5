using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePart1
{
    public class Coupoun
    {
        public static int GetSign(int num)
        {
            if(num < 0)
            {
                return -1;
            }
            else if (num > 0)
            {
                return 1;
            } else
            {
                return 0;
            }
        }
        public static bool isRangeVersion1(int num)
        {
            return false;
        }
        public static bool isRangeVersion2(int num)
        {
            return false;
        }
        public static decimal CalculateCupon(decimal purchase)
        {
            if(purchase < 10)
            {
                return 0.0m;
            }else if(purchase < 20)
            {
                return 2.0m;
            }
            else
            {
                return 3.0m;
            }
        }
    }
}
