using System;
using System.Diagnostics;

class nineteen
{
    public static void Main()
    {
        int sundaycount=0;
	Stopwatch sw = new Stopwatch();
        
	sw.Start();
        for (int year=1901;year<2001;year++)
        {for (int month=1;month<13;month++)
        {
            DateTime dayCheck = new DateTime(year,month,1);
            if (dayCheck.DayOfWeek==DayOfWeek.Sunday)
                sundaycount++;
            Console.WriteLine("Now in year {0} month {1} #sundays {2}",year,month,sundaycount);
        }
        }
	sw.Stop();
	Console.WriteLine("Elapsed time {0} ms",sw.ElapsedMilliseconds);
    }
}