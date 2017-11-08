using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Files
{
    class File
    {
        public string Root { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var allFiles = new List<File>();

            for (int i = 0; i < n; i++)
            {
                string inputPath = Console.ReadLine();

                string root = inputPath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).First();
                string[] fileNameAndSize = inputPath.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Last().Split(';');

                File file = new File();
                file.Root = root;
                file.FileName = fileNameAndSize[0];
                file.FileSize = long.Parse(fileNameAndSize[1]);

                allFiles.Add(file);
            }
            string[] endCmd = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string rootSearch = endCmd.Last();
            string extSearch = endCmd.First();

            var output = new Dictionary<string, long>();

            foreach (var file in allFiles)
            {
                if (file.Root == rootSearch && file.FileName.EndsWith(extSearch))
                {
                    output[file.FileName] = file.FileSize;
                }
            }

            if (output.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in output.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value} KB");
                }

            }
        }
    }
}
