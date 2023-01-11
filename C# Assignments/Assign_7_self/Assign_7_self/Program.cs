using System;
using System.IO;

namespace Assign_7_self
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make  astring path giving the path of the folder
            string path = @"C:\Training\C Sharp\Capg_training_Assignments\Self_Ass_6";

            // 
            var dir = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);


            Console.WriteLine("Getting file directories");
            foreach(string item in dir)
            {
                var dirinfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirinfo.FullName}");
            }
            

            Console.WriteLine("Reading .txt files");
            foreach(string f in files)
            {
                var fileinformation = new FileInfo(f);
                Console.WriteLine(f.Length);
                Console.WriteLine($"File name is : {Path.GetFileName(f)} - and it's size is : {fileinformation.Length}");
            }
        }
    }
}
