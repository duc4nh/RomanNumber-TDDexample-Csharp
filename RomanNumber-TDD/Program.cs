using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        public String Convert(int number)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                result.Append("I");
            }

            return result.ToString();
        }
    }
}
