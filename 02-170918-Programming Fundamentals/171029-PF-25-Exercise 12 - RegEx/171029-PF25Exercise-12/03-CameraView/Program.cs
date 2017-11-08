using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();

            string pattern = @"(?<=\|<)\w+";

            MatchCollection cameraView = Regex.Matches(text, pattern);
            List<string> output = new List<string>();

            foreach (Match camera in cameraView)
            {
                output.Add(new string (camera.Value.Skip(nums[0]).Take(nums[1]).ToArray()));
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
