using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    internal class WorkingWithText
    {
        public static void ExerciseOne()
        {
            //Exercise 1, Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.Clear();
            var numbers = new List<int>();
            Console.WriteLine("Enter a few numbers seperated by a hyphen eg. 5-6-7-8-9 or 20-5-34-10-1");
            var input = Console.ReadLine();
            numbers = input.Split('-').Select(x => int.Parse(x)).ToList();
            var inSequince = numbers.SequenceEqual(Enumerable.Range(numbers[0], numbers.Count()));
                if (inSequince == true)
                Console.WriteLine("Consecutive");
                else
                Console.WriteLine("Non Consecutive");
            Console.ReadKey();
        }
        public static void ExerciseTwo()
        {
            //Exercise 2, Write a program and ask the user to enter a few numbers separated by a hyphen.
            //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            var numbers = new List<int>();
                Console.Clear();
                Console.WriteLine("Enter a few numbers seperated by a hyphen eg. 5-6-7-8-9 or 20-5-34-10-1");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    return;
                numbers = input.Split('-').Select(x => int.Parse(x)).ToList();
            foreach (var number in numbers)
                {
                    var temp = numbers.Where(x => x.Equals(number)).Count();
                    if (temp > 1)
                        Console.Clear();                                                                                                    
                        Console.WriteLine("Duplicates");
                        break;
                }
            Console.ReadKey();
        }
        public static void ExerciseThree()
        {
            //Exercise 3, Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            //If the user doesn't provide any values, consider it as invalid time.
             
                CultureInfo enUS = new CultureInfo("en-US");
                Console.Clear();
                Console.WriteLine("Please enter a time in the following 24-hour format 00:00");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid Time");
                    return;
                }
                else
                {
                    var isValidTime = DateTime.TryParseExact(input, "hh:mm", enUS, DateTimeStyles.None, out var time);
                    if (isValidTime)
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Time");
                    }
                }
                Console.ReadKey();
        }
        public static void ExerciseFour()
        {
            //Exercise 4, Write a program and ask the user to enter a few words separated by a space.
            //Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
            //Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            Console.Clear();
            Console.WriteLine("Enter a few words seperated by spaces eg. Hello World");
            var input = Console.ReadLine();
            input = input.ToLower();
            var output = textInfo.ToTitleCase(input);
            Console.WriteLine(output.Replace(" ",""));
            Console.ReadKey();
        }
        public static void ExerciseFive()
        {
            //Exercise 5, Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
            //So, if the user enters "inadequate", the program should display 6 on the console.
            Console.Clear();
            Console.WriteLine("Enter a word");
            var input = Console.ReadLine().ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                foreach (var vowel in vowels)
                {
                    if (input[i] == vowel)
                        count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
        public static void Strings()
        {
            //Trim Whitespace
            Console.Clear();
            var fullName = "Mosh Hamedani ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // Split via Substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName Substring: " + firstName);
            Console.WriteLine("LastName Substring: " + lastName);
            
            // Split via Split method
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName Split: " + names[0]);
            Console.WriteLine("LastName Split: " + names[1]);

            //Replace
            fullName.Replace("Mosh", "Moshfegh");
            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh"));

            //Working with Empty string or NULLs
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            //Convert to String or Number
            var str = "25";
            var age = Convert.ToByte(str);
                Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
            Console.ReadLine();
        }
        public static void Summerising()
        {
            //Summerise Text
            Console.Clear();
            var sentence = "This is going to be a really really really really really long text.";
            var summery = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summery);
            Console.ReadLine();
        }
        public static void StringBuilder()
        {
            //Append
            Console.Clear();
            var builder = new StringBuilder("Hello World");
            builder
            .Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10);
            Console.WriteLine(builder);

            //Replace
            builder.Replace('-', '+');
            Console.WriteLine(builder);

            //Remove
            builder.Remove(0, 10);
            Console.WriteLine(builder);

            //Insert
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            // Display Index
            Console.WriteLine("First Char: " + builder[0]);
            Console.ReadLine();
        }
    }
}
