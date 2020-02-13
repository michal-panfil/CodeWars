using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.WhichAreIn
{
   public static class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {

            return  array1.Distinct().Where(a => array2.Any(s => s.Contains(a))).OrderBy(r => r).ToArray();
            

        }
    }
}
