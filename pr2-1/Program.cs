using System.IO;
using System;

namespace ShowFilesDemo
{
    class Program
    {
        static void ShowDirectory(DirectoryInfo dir)
        {
            // Показать все файлы 

            foreach (FileInfo file in dir.GetFiles())

            {
                Console.WriteLine("File: {0}", file.FullName);
            }
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                ShowDirectory(subDir);
            }

        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Tanco\OneDrive\Рабочий стол\yziki"); ShowDirectory(dir);
        }
    }
}
