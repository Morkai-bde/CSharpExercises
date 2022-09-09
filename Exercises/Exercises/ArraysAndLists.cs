using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    internal class ArraysAndLists
    {
        static public void ExerciseOne()
        {
            //Exercise 1, Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            //Then display a message based on the names provided based on the patern provided by the exercise documentation.
            var friends = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter any name or press Enter to Display output as per Exercise instructions");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                friends.Add(input);
            }

            if (friends.Count == 0)
                Console.WriteLine();
            if (friends.Count == 1)
                Console.WriteLine("{0} like your post", friends[0]);
            if (friends.Count == 2)
                Console.WriteLine("{0} and {1} like your post", friends[0], friends[1]);
            if (friends.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", friends[0], friends[1], friends.Count -2);
            Console.ReadLine();
        }

        static public void ExerciseTwo()
        {
            //Exercise 2, Write a program that asks a user's name and stores it in an array, Use the array to reverse the name and display it revesed.
            Console.Clear();
            Console.WriteLine("Enter your Name: ");
            var input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);
            Console.WriteLine("Your name Reversed is: " + reversed);
            Console.ReadLine();
        }

        static public void ExerciseThree()
        {
            //Exercise 3, Write a program that asks the user to enter 5 numbers, If a number has been previously entered, display an error message and ask the user to re-try
            //once all numbers have been successfully entered, display them on the console.
            var i = 5;
            var numbers = new List<int>();
            while (i > 0)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number");
                var input = Console.ReadLine();
                if (numbers.Contains(Convert.ToInt32(input)))
                    {
                    Console.WriteLine("Number already exists, please try again");
                    }
                else
                numbers.Add(Convert.ToInt32(input));
                i--;
            }
            numbers.Sort();
            Console.Clear();
            foreach (var number in numbers)
            Console.WriteLine(number);
            Console.ReadLine();
        }

        static public void ExerciseFour()
        {//Ecercise 4, Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.
         //Display the unique numbers that the user has entered.

            var numbers = new List<int>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a number or type \"Quit\" to Exit.");
                var input = Console.ReadLine();

                if (input == "Quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            List<int> uniques = numbers.Distinct().ToList();
            foreach (var unique in uniques)
                Console.WriteLine(unique);
                Console.ReadLine();
        }

        static public void ExerciseFive()
        //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        {
            int[] numbers;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter 5 numbers seperated by commas EG. 5, 1, 9, 2, 10");
                var input = Console.ReadLine();
                numbers = input.Split(',').Select(x => int.Parse(x)).ToArray();
                if (numbers.Length < 5)
                {
                    Console.WriteLine("InvalidList, Please try again");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            var output = numbers.OrderBy(x => x).ToList();
            Console.WriteLine("{0} {1} {2}", output[0], output[1], output[2]);
            Console.ReadLine();
        }
    }
}