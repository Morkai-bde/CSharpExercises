using System;

namespace Exercises.Exercises.Intermediate
{
    internal class IntermediateMenu
    {
        private bool canContinue;

        public IntermediateMenu()
        {
            canContinue = true;
            while (canContinue)
            {
                PrintMenu();
                HandleInput();
            }
        }

        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("This Program does not capture errors or validates data entered as per the instructions of Excercises");
            Console.WriteLine();
            Console.WriteLine("1. Stopwatch\n");
            Console.WriteLine("Choose an Exercise Menu, \"b\" to go back or \"q\"to exit");
        }

        private void HandleInput()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Classes.ExerciseOne();
                    break;
                //case "2":
                //    Classes.();
                //    break;
                case "b":
                    canContinue = false;
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
