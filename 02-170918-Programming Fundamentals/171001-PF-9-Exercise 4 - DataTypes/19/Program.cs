using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPictures = int.Parse(Console.ReadLine());
            int timeFilter = int.Parse(Console.ReadLine());
            int percentGoodPictures = int.Parse(Console.ReadLine());
            int timeUpload = int.Parse(Console.ReadLine());

            long totalTimeFilter = (long)nPictures * timeFilter;
            int goodPictures = (int)(Math.Ceiling(nPictures * percentGoodPictures / 100.0));
            long totalTimeUpload = timeUpload * (long)goodPictures;

            long totalSeconds = totalTimeFilter + totalTimeUpload;

            TimeSpan t = TimeSpan.FromSeconds(totalSeconds);

            string formatedTime = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}", t.Days, t.Hours, t.Minutes, t.Seconds);

            Console.WriteLine(formatedTime);

        }
    }
}