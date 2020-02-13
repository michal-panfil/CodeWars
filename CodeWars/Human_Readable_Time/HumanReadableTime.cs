using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Human_Readable_Time
{
    public static class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds == 0) return "00:00:00";
            int hr = seconds/3600;
            int min = (seconds - hr * 3600) / 60;
            int sec = seconds - (hr * 3600) - (min *60) ;
            
            return $"{hr.ToString("D2")}:{min.ToString("D2")}:{sec.ToString("D2")}";
        }

    }
}
