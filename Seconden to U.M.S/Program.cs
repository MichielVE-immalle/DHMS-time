using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconden_to_U.M.S
{
    class Program
    {
        static void SecTosHoursMinsSecs(int totalSeconds, out int days, out int hours, out int mins, out int secs)
        {
            int rest = 0;

            days = totalSeconds / (60 * 60 * 24);
            rest = totalSeconds % (60 * 60 * 24);
            hours = rest / (60 * 60);
            rest = rest % (60 * 60);
            mins = rest / 60;
            secs = rest % 60;
        }

        static void Main(string[] args)
        {
            //outVersie
            int dagen = 0;
            int uur = 0;
            int minuten = 0;
            int seconden = 0;
            SecTosHoursMinsSecs(86401, out dagen, out uur, out minuten, out seconden);
            Console.WriteLine("{0} dagen, {1} uur, {2} minuten, {3} seconden", dagen, uur, minuten, seconden);
        }
    }
}
