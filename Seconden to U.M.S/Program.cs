using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconden_to_U.M.S
{
    class Time
    {
        public int days = 0;
        public int hours = 0;
        public int mins = 0;
        public int secs = 0;

        public void SecToHoursMinsSecs(int totalSeconds)
        {
            int rest = 0;

            days = totalSeconds / (60 * 60 * 24);
            rest = totalSeconds % (60 * 60 * 24);
            hours = rest / (60 * 60);
            rest = rest % (60 * 60);
            mins = rest / 60;
            secs = rest % 60;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Time b = new Time();

                b.SecToHoursMinsSecs(86401);

                Console.WriteLine("{0} dagen, {1} hours, {2} minutes, {3} seconds", b.days, b.hours, b.mins, b.secs);
            }
        }
    }
}
