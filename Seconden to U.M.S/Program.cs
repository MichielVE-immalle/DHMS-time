﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconden_to_U.M.S
{
    //struct HMSTime
    //{
    //    public int Days;
    //    public int Hours;
    //    public int Mins;
    //    public int Secs;
    //}

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

        //static HMSTime SecToHMS(int totalSeconds)
        //{
        //    HMSTime a;
        //    int rest;

        //    a.Days = totalSeconds / (60 * 60 * 24);
        //    rest = totalSeconds % (60 * 60 * 24);
        //    a.Hours = rest / (60 * 60);
        //    rest = rest % (60 * 60);
        //    a.Mins = rest / 60;
        //    a.Secs = rest % 60;

        //    return a;
        //}

        //static void SecTosHoursMinsSecs(int totalSeconds, out int days, out int hours, out int mins, out int secs)
        //{
        //    int rest = 0;

        //    days = totalSeconds / (60 * 60 * 24);
        //    rest = totalSeconds % (60 * 60 * 24);
        //    hours = rest / (60 * 60);
        //    rest = rest % (60 * 60);
        //    mins = rest / 60;
        //    secs = rest % 60;
        //}

        static void Main(string[] args)
        {
            SecToHoursMinsSecs(61);

            Console.WriteLine("{0} hours {1} minutes and {2} seconds", hours, mins, secs);

            //MetMethodEnStruct

            //HMSTime time = SecToHMS(86401);
            //Console.WriteLine("{0} dagen, {1} uren, {2} minuten, {3} seconden", time.Days, time.Hours, time.Mins, time.Secs);
        }
    }
}
