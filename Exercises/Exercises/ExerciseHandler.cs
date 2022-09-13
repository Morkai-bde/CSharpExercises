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
            Console.WriteLine("This Program does not capture errors or validates data entered as per the instructions of Excercises");
            Console.WriteLine();
            Console.WriteLine("1. Control Flow \n2. Arrays and Lists\n3. Working With Dates\n4. Working with Text\n5. Working With Files");
            Console.WriteLine("Choose an Exercise Menu or \"q\" to exit");
        }

        private void HandleInput()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    ControlFlowMenu();
                    break;
                case "2":
                    ArraysAndListsMenu();
                    break;
                case "3":
                    WorkingWithDatesMenu();
                    break;
                case "4":
                    WorkingWithTextMenu();
                    break;
                case "5":
                    WorkingWithFilesMenu();
                    break;
                case "q":
                    canContinue = false;
                    break;
                default:
                    break;
            }
        }
        private void ControlFlowMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Exercise Number between 1 and 9, enter to go back, or \"q\" to quit");
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
        private void ArraysAndListsMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Exercise Number between 1 and 5, enter to go back or \"q\" to exit");
            switch (Console.ReadLine())
            {
                case "1":
                    ArraysAndLists.ExerciseOne();
                    break;
                case "2":
                    ArraysAndLists.ExerciseTwo();
                    break;
                case "3":
                    ArraysAndLists.ExerciseThree();
                    break;
                case "4":
                    ArraysAndLists.ExerciseFour();
                    break;
                case "5":
                    ArraysAndLists.ExerciseFive();
                    break;
                case "q":
                    canContinue = false;
                    break;
                default:
                    break;
            }
        }
        private void WorkingWithDatesMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Exercise Number between 1 and 2 or press enter to go back or \"q\" to exit");
            switch (Console.ReadLine())
            {
                case "1":
                    WorkingWithDates.DateTimeExersise();
                    break;
                case "2":
                    WorkingWithDates.TimeSpanExercise();
                    break;
                case "q":
                    canContinue = false;
                    break;
                default:
                    break;
            }
        }
        private void WorkingWithTextMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose and Exercise Number between 1 and 5 or press enter to go back or \"q\" to exit");
            switch (Console.ReadLine())
            {
                case "1":
                    WorkingWithText.ExerciseOne();
                    break;
                case "2":
                    WorkingWithText.ExerciseTwo();
                    break;
                case "3":
                    WorkingWithText.ExerciseThree();
                    break;
                case "4":
                    WorkingWithText.ExerciseFour();
                    break;
                case "5":
                    WorkingWithText.ExerciseFive();
                    break;
                case "q":
                    canContinue = false;
                    break;
                default:
                    break;
            }
        }
        private void WorkingWithFilesMenu()
        {
            Console.Clear();
            Console.WriteLine("This menu is empty press enter to go back or \"q\" to exit");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("This Menu is Empty");
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
