using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    internal class ControlFlow
    {
        static public void ExerciseOne()
        {
            //Exercise 1, Write a program to validate that a number is between 1 and 10 
            Console.Clear();
            Console.WriteLine("This Excercise verifies if the number entered is Valid or Invalid");
            Console.WriteLine();
            Console.WriteLine("Please enter a number between 1 and 10");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (input < 1 || input > 10)
                Console.WriteLine("Invalid Number");
            else
                Console.WriteLine("Valid Number");
            Console.ReadKey();
        }
        static public void ExerciseTwo()
        {
            //Exercise 2, Write a program that takes two numbers form the console and displays the maximum of the two
            Console.Clear();
            Console.WriteLine("This Excercise displays which number entered is the larger number");
            Console.WriteLine();
            Console.WriteLine("Please enter a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please enter another number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (numberOne > numberTwo)
                Console.WriteLine(numberOne + " Is the larger number");
            else
                Console.WriteLine(numberTwo + " Is the larger number");
            Console.ReadKey();
        }
        static public void ExerciseThree()
        {
            //Exercise 3, Write a program that takes the hight and width of an image and tells if it landscape or portrait
            Console.Clear();
            Console.WriteLine("This Excercise displays the orientation of an image based on the values entered");
            Console.WriteLine();
            Console.WriteLine("Please enter the height of an image");
            int hight = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please enter the width of an image");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (hight > width)
                Console.WriteLine("The image is Portrait");
            else if (width > hight)
                Console.WriteLine("The image is Landscape");
            else
                Console.WriteLine("The image is Square");
            Console.ReadKey();
        }
        static public void ExerciseFour()
        {
            //Excercise 4, Write a program that takes a speed limit, then asks for the speed of a car, if the car is going slower than the speed limit, write ok
            //if the car is going over the speed limit, give 1 demerit point for each 5km.h above the speed limit, if more than 12, display License Suspended.
            Console.Clear();
            Console.WriteLine("This Excercise Displayes Ok, Number of Demerit Points, or License Suspended Depending on values entered");
            Console.WriteLine();
            Console.WriteLine("Please enter a speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please enter car speed");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int speedDifference = carSpeed - speedLimit;
            if (speedDifference < 0)
                Console.WriteLine("OK");
            else if (speedDifference / 5 < 13)
                Console.WriteLine(speedDifference / 5 + " Demerit Points");
            else
                Console.WriteLine("License Suspended");
            Console.ReadKey();
        }
        static public void ExerciseFive()
        {
            // Exercise 5, Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder, then display the count on the console.
            Console.WriteLine("This Exercise displays how many numbers between 1 and 100 are divisible by 3");
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }

        static public void ExerciseSix()
        {
            // Exercise 6, Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console.
            int count = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter any number or \"ok\" to calculate the sum of all numbers entered:");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                count += Convert.ToInt32(input);
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
        static public void ExerciseSeven()
        {
            // Excercise 7, Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            Console.Clear();
            Console.WriteLine("Enter a number to calculate it's facrotial:");
            var input = Convert.ToInt32(Console.ReadLine());
            var factorial = input;
            for (int i = input - 1; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();
        }
        static public void ExerciseEight()
        {
            //Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won";
            //otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            Console.WriteLine();
            Random rnd = new Random();
            var count = 4;
            var secretNo = rnd.Next(1,10);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("A random number between 1 and 10 has been generated, you have " + (0 + count) + " guesses.");
                var input = Console.ReadLine();
                if (Convert.ToInt32(input) == secretNo)
                {
                    Console.Clear();
                    Console.WriteLine("Well done, You guessed the correct number");
                    break;
                }
                if (Convert.ToInt32(input) != secretNo)
                {
                    count--;
                }
                if (count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You Loose, the number was " + secretNo);
                    break;
                }
            }
            Console.ReadKey();
        }
        static public void ExerciseNine()
        {
            // Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console.
            // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            Console.Clear();
            Console.WriteLine("Enter a list of numbers, Seperated by a comma, EG: 5, 3, 8, 1, 4");
            var input = Console.ReadLine().Replace(" ", "");
            var numberList = input.Split(',');
            Console.WriteLine("The highest number is: " + numberList.Max());
            Console.ReadLine();

        }
    }
}
