using System;
using System.IO;

namespace Q_1_DirectoryInfo_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store the path into a string
            string path = @"C:\Users\ANUBHASR\source\repos\File_Handling";

            // Made a directory that will read all files in the path and made a files that will read all .txt 
            // files in the given directory
            var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            var file = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

            // Made a loop to display directory full name
            Console.WriteLine("......Displaying Directories.....");
            foreach(string str in dirs)
            {
                var dirInfo = new DirectoryInfo(str);
                Console.WriteLine($"{dirInfo.FullName}");
            }

            // Made a loop to display .txt file details
            Console.WriteLine("\n......Displaying .txt Files.....");
            foreach(string f in file)
            {
                var fileInfo = new FileInfo(f);
                Console.WriteLine($"{Path.GetFileName(f)} - {fileInfo.Length} bytes");
            }
        }
    }
}
