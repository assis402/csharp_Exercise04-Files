using System;
using System.IO;

namespace Exercise04_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");

            string sourceFolderPath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFolderPath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFolderPath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFilePath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach(string line in lines)
                    {

                    }
                }
            }
        }
    }
}
