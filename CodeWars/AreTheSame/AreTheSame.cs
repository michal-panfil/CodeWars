using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.AreTheSame
{
    public class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            return a != null && b != null  && (a.Length == b.Length) && a.All(i => b.Contains(i * i)) || b.All(i => a.Contains(i * i));
        }
    }
}
