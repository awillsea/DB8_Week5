using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1_Find_PrimeNums
{
    public class Lab5_1
    {

        public static int GetPrime(int primeindex)
        {
            // to find primes, they can only be divided by themselves and nothing else;
            int count = 0;
            int value = 0;

                for (int i = 1; i <= 10000; i++)
                {
                    bool prime = CheckIfPrime(i);
                    if (prime)
                    {
                        count++;
                    }
                    value = i;
                    if (count == primeindex)
                    {
                        break;
                    }
                    
                }
            return value;
        }

        public static bool CheckIfPrime(int _number)
        {
           
      
                int a = 0;
                for (int i = 1; i <= _number; i++)
                {
                    if (_number % i == 0)
                    {
                        a++;
                    }
                }
                
                if (a == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
            
           
        
    }
}
