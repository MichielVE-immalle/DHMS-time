using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconden_to_U.M.S
{
    class Program
    {
        static int days;
        static int hours;
        static int mins;
        static int secs;

        static void SecToHoursMinsSecs(int totalSeconds)
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
        }
    }
}
