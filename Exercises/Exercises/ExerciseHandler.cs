using Exercises.Exercises.Basic;
using Exercises.Exercises.Advanced;
using Exercises.Exercises.Intermediate;
using System;

namespace Exercises.Exercises
{
    internal class ExerciseHandler
    {
        private bool canContinue;

        public ExerciseHandler()
        {
            canContinue = true;
            while (canContinue)
            {
                PrintMenu();
                HandleInput();
            }
        }

        private void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose a Course Set");
            Console.WriteLine();
            Console.WriteLine("1. Basic \n2. Intermediate\n3. Advanced\n");
            Console.WriteLine("Choose an Course Menu or \"q\" to exit");
        }

        private void HandleInput()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    new BasicMenu();
                    break;
                case "2":
                    new IntermediateMenu();
                    break;
                case "3":
                    new AdvancedMenu();
                    break;
                case "q":
                    canContinue = false;
                    break;
                default:
                    break;
            }
        }
    }
}
