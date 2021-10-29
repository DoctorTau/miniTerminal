using System;
using System.IO;

namespace laba1_miniTerminal
{
    class Program
    {
        static DirectoryInfo currentDirectory = new DirectoryInfo(path: Directory.GetCurrentDirectory());
        static void Main(string[] args)
        {
            string inputDir = Console.ReadLine();
            currentDirectory = new DirectoryInfo(path: inputDir);

            foreach (var dirInfo in currentDirectory.GetDirectories())
            {
                Console.WriteLine(dirInfo.Name);
            }

            foreach (var fileInfo in currentDirectory.GetFiles())
            {
                Console.WriteLine(fileInfo.Name);
            }
        }
    }
}
