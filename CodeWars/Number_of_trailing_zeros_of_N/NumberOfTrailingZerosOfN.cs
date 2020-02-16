using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Number_of_trailing_zeros_of_N
{
   public static class NumberOfTrailingZerosOfN
    {
        public static int TrailingZeros(int n)
        {
            int result = 0;
            for (int i = 5; i < int.MaxValue; i *= 5)
            {
                var countZeros = n / i;
                if (countZeros == 0) break;
                result += countZeros;
            }
            return result;
        }
    }
}
