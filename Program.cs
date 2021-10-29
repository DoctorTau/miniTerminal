using System;
using System.IO;

namespace laba1_miniTerminal
{
    class Program
    {
        static DirectoryInfo currentDirectory = new DirectoryInfo(path: Directory.GetCurrentDirectory());
        static void Main(string[] args)
        {
            Console.WriteLine("Input directiry: ");
            string inputDir = Console.ReadLine();
            Console.WriteLine("Input depth: ");
            int depth = Convert.ToInt32(Console.ReadLine());

            currentDirectory = new DirectoryInfo(path: inputDir);

            Console.WriteLine(currentDirectory.Name);

            foreach (var dirInfo in currentDirectory.GetDirectories())
            {
                Console.WriteLine("[" + dirInfo.FullName + "]");
            }

            foreach (var fileInfo in currentDirectory.GetFiles())
            {
                Console.WriteLine(fileInfo.Name + " (" + (fileInfo.Length / 8) + " B)");
            }
        }
    }
}
