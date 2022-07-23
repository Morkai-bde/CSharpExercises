using System;

namespace Fuckthis.Excercises
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
            Console.WriteLine("This Program does not capture errors or validates data entered as per the instructions of Excercises");
            Console.WriteLine();
            Console.WriteLine("Choose an Exercise number between 1 and 9 or \"q\" to exit");
        }

        private void HandleInput()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    ControlFlow.ExerciseOne();
                    break;
                case "2":
                    ControlFlow.ExerciseTwo();
                    break;
                case "3":
                    ControlFlow.ExerciseThree();
                    break;
                case "4":
                    ControlFlow.ExerciseFour();
                    break;
                case "5":
                    ControlFlow.ExerciseFive();
                    break;
                case "6":
                    ControlFlow.ExerciseSix();
                    break;
                case "7":
                    ControlFlow.ExerciseSeven();
                    break;
                case "8":
                    ControlFlow.ExerciseEight();
                    break;
                case "9":
                    ControlFlow.ExerciseNine();
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
