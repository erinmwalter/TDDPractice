using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice
{
    class Diamond
    {
        public string GetDiamond(char letter)
        {
            string output = "";
            if (letter.ToString().ToUpper() == "A")
            {
                return "A";
            }
            else
            {
                output += GetOutsideSpaces('A', letter);
                output += "A\n";
                for(char c = 'B'; c < letter; c++)
                {
                    output += GetOutsideSpaces(c, letter);
                    output += c;
                    output += GetInsideSpaces(c);
                    output += c;
                    output += "\n";
                }
                for (char c = letter; c >= 'B'; c--)
                {
                    output += GetOutsideSpaces(c, letter);
                    output += c;
                    output += GetInsideSpaces(c);
                    output += c;
                    output += "\n";
                }
                output += GetOutsideSpaces('A', letter);
                output += 'A';

                return output;
            }
        }

        public string GetInsideSpaces(char letter)
        {
            string output = "";
            for(char c = 'A'; c < letter; c++)
            {
                output += " ";
            }
            return output;
        }

        public string GetOutsideSpaces(char current, char original)
        {
            string output = "";
            for(char c = current; c < original; c++)
            {
                output += " ";
            }
            return output;
        }
    }
}
