using System;


namespace Exercises.Exercises.Advanced
{
    internal class AdvancedMenu
    {
        private bool canContinue;

        public AdvancedMenu()
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
            Console.WriteLine("This Menu is Empty \n");
            Console.WriteLine("Choose an Exercise Menu, \"b\" to go back or \"q\"to exit");
        }

        private void HandleInput()
        {
            switch (Console.ReadLine())
            {
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
