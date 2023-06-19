using System;
using System.IO;
using System.Linq;

namespace Exercise16  
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users";

            // Get all files in the directory
            FileInfo[] files = new DirectoryInfo(directoryPath).GetFiles();

            // 1. Number of text files
            int numTextFiles = files.Count(f => f.Extension == ".txt");
            Console.WriteLine($"Number of text files: {numTextFiles}");

            // 2. Number of files per extension type
            var fileCountByExtension = files.GroupBy(f => f.Extension)
                                             .Select(g => new { Extension = g.Key, Count = g.Count() });
            foreach (var fileInfo in fileCountByExtension)
            {
                Console.WriteLine($"Extension: {fileInfo.Extension}, Count: {fileInfo.Count}");
            }

            // 3. Top 5 largest files
            var largestFiles = files.OrderByDescending(f => f.Length)
                                   .Take(5)
                                   .Select(f => new { FileName = f.Name, Size = f.Length });
            Console.WriteLine("Top 5 largest files:");
            foreach (var fileInfo in largestFiles)
            {
                Console.WriteLine($"File Name: {fileInfo.FileName}, Size: {fileInfo.Size} bytes");
            }

            // 4. File with maximum length
            var maxFile = files.OrderByDescending(f => f.Length)
                               .FirstOrDefault();
            Console.WriteLine($"File with maximum length: {maxFile.Name}");
        }
    }
}
