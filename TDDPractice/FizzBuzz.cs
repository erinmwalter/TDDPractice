﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice
{
    class FizzBuzz
    {
        public string GetFizzBuzz(int num)
        {
            if(num % 5 == 0 && num % 3 == 0)
            {
                return "fizzbuzz";
            }
            if (num % 5 == 0)
            {
                return "buzz";
            }
            if (num % 3 == 0)
            {
                return "fizz";
            }

            return "";
        }
    }
}
