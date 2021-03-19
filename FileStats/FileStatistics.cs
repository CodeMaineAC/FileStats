using System;
using System.IO;

namespace FileStats
{
    class FileStatistics
    {
        static void Main(string[] args)
        {

            string fileName;
            Console.WriteLine("HEnter a file name>> ");
            fileName = Console.ReadLine();

           


            if(File.Exists(fileName))
            {
                Console.WriteLine("File exists");
                Console.WriteLine("File was created {0}" +
                    "\nFile was last written to {1}", 
                    File.GetCreationTime(fileName),
                    File.GetLastWriteTime(fileName));

            }
            else
            {
                Console.WriteLine("FILE DOES NOT EXIST");
            }
        }
    }
}
