using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDDPractice
{
    class PasswordVerifier
    {
        public bool Verify(string password)
        {
            int numFailed = 0;
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (password.Length < 8)
            {
                numFailed++;
            }
            if (password == null)
            {
                numFailed++;
            }
            if (!password.Any(char.IsUpper))
            {
                numFailed++;
            }
            if (!password.Any(char.IsDigit))
            {
                numFailed++;
            }

            if(numFailed > 2)
            {
                return false;
            }
            return true;
        }

    }
}
