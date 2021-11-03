using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice
{
    class OddEvenKata
    {
        public string OddEvenPrime(int num)
        {
            
            if(num % 2 == 0 && num != 2)
            {
                return "EVEN";
            }
            else
            {
                for (int i=3; i < num/2; i+= 2)
                {
                    if (num % i == 0)
                    {
                        return "ODD";
                    }
                }
                return "PRIME";
            }   
        }
    }
}
