using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercises.Exercises
{
    internal class WorkingWithFiles
    {

        public static void ExerciseOne()
        {
            //Exercise 1, Write a program that reads a text file and displays the number of words.
            var file = @".\words.txt";
            var words = File.ReadAllText(file).Split(' ').ToArray();
            Console.WriteLine("The file has " + words.Length +" words.");
            Console.ReadKey();
        }
        public static void ExerciseTwo()
        {
            //Exercise 2, Write a program that reads a text file and displays the longest word in the file.
            var file = @".\words.txt";
            string longest = "";
            var words = File.ReadAllText(file).Split(' ').ToArray();
            foreach(var word in words)
            {
                if (word.Length > longest.Length)
                    longest = word;
            }
            Console.WriteLine("The longest word is: " + longest);
            Console.ReadKey();
        }

        public static void Files()
        {
            var path = @"C:\somefile.jpg";

            File.Copy(@"C:\temp\myfile.jpg", @"D:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

        }

        public static void Directories()
        {
            Directory.CreateDirectory(@"C:\temp\folder1");
            var files = Directory.GetFiles(@"C:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directories);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }

        public static void Paths()
        {
            var path = @"C:\projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf(".");
            var extention = path.Substring(dotIndex);

            Console.WriteLine("Extention: " + Path.GetExtension(path));
            Console.WriteLine("Extention: " + Path.GetFileName(path));
            Console.WriteLine("Extention: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Extention: " + Path.GetDirectoryName(path));
        }
    }
}
