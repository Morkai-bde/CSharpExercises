using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises.Exercises.Intermediate
{

    internal class Classes

    {
        static public void ExerciseOne()
        {
            var canContinue = true;
            while (canContinue)
            {
                Console.Clear();
                //Console.WriteLine("Please choose an option:\n1. Start Stopwatch\n2. Set Lap Time\n3. Pause Stopwatch\n4. Stop Stopwatch" +
                //"\n5. Show Lap Times\n6. Show Total Time\n7. Clear Lap Times\n8. Clear all Times.");

                var stopwatch1 = new Stopwatch("Carlclock");
                var stopwatch2 = new Stopwatch("Casycasio");
                var stopwatch3 = new Stopwatch("Tomtime");


                stopwatch1.Start();
                //stopwatch1.Lap();
                Thread.Sleep(1000);
                stopwatch1.Lap();
                Thread.Sleep(2000);
                stopwatch1.Lap();
                Thread.Sleep(3000);
                stopwatch1.Lap();
                stopwatch1.Stop();
                stopwatch1.PrintLaps();
                stopwatch1.PrintTime();

                stopwatch2.Start();
                Thread.Sleep(1000);
                stopwatch2.Reset();
                stopwatch2.Stop();
                Thread.Sleep(1000);
                stopwatch2.Start();
                Thread.Sleep(2000);
                stopwatch2.Stop();
                stopwatch2.PrintTime();

                stopwatch3.Start();
                Thread.Sleep(1000);
                stopwatch3.Stop();
                stopwatch3.Reset();
                stopwatch3.Start();
                Thread.Sleep(3000);
                stopwatch3.Stop();
                stopwatch3.PrintTime();


                Console.ReadKey();
                canContinue = false;


                //switch (Console.ReadLine())
                //{
                //    case "1":
                //        stopwatch1.Start();
                //        break;
                //    case "2":
                //        Console.WriteLine("Not Implemented");
                //        break;
                //    case "3":
                //        Console.WriteLine("Not Implemented");
                //        break;
                //    case "4":
                //        stopwatch1.Stop();
                //        break;
                //    case "5":
                //        Console.WriteLine("Not Implemented");
                //        break;
                //    case "6":
                //        Console.WriteLine("Not Implemented");
                //        break;
                //    case "7":
                //        Console.WriteLine("Not Implemented");
                //        break;
                //    case "b":
                //        canContinue = false;
                //        break;
                //    case "q":
                //        Environment.Exit(0);
                //        break;
                //    default:
                //        break;
                //}
            }
        }
    }
}

    //internal class Classes
    //{
    //    public class Person
    //    {
    //        public string Name;

    //        public void Introduce(string to)
    //        {
    //            Console.WriteLine("Hi {0}, I am  {1}", to, Name);
    //        }

    //        public static Person Parse(string str)
    //        {
    //            var person = new Person();
    //            person.Name = str;

    //            return person;
    //        }
    //    }

    //    static public void Class()
    //    {
    //        Console.Clear();
    //        var person = Person.Parse("John");
    //        person.Introduce("Mosh");
    //        Console.ReadKey();
    //    }

    //    static public void Constructor()
    //    {
    //        Console.Clear();
    //        var customer = new Customer();
    //        customer.Id = 1;
    //        customer.Name = "John";

    //        var order = new Order();

    //        Console.WriteLine(customer.Id);
    //        Console.WriteLine(customer.Name);

    //        Console.ReadKey();
    //    }

    //    static public void UsePoints()
    //    {
    //        Console.Clear();
    //        try
    //        {
    //            var point = new Point(10, 20);
    //            point.Move(new Point(40, 60));
    //            Console.WriteLine("Point is at: {0}, {1}", point.X, point.Y);

    //            point.Move(100, 200);
    //            Console.WriteLine("Point is at: {0}, {1}", point.X, point.Y);
    //        }
    //        catch (Exception)
    //        {

    //            Console.WriteLine("An unexpected error occured");
    //        }

    //        Console.ReadKey();
    //    }
    //    static public void UseParams()
    //    {
    //        Console.Clear();
    //        var calculator = new Calculator();
    //        Console.WriteLine(calculator.Add(1, 2));
    //        Console.WriteLine(calculator.Add(1, 2, 3));
    //        Console.WriteLine(calculator.Add(1, 2, 3, 4));
    //        Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
    //        Console.ReadKey();
    //    }
    //    static public void Out()
    //    {
    //        Console.Clear();
    //        try
    //        {
    //            var num = int.Parse("abc");
    //        }
    //        catch (Exception)
    //        {

    //            Console.WriteLine("Conversion failed.");
    //        }

    //        int number;
    //        var result = int.TryParse("abc",out number);
    //        if(result)
    //            Console.WriteLine(number);
    //        else
    //        {
    //            Console.WriteLine("Conversion failed.");
    //        }

    //        Console.ReadKey();
    //    }
        
    //    static public void Fields()
    //    {
    //        Console.Clear();
    //        var customer = new Customer(1);
    //        customer.Orders.Add(new Order());
    //        customer.Orders.Add(new Order());

    //        customer.Promote();

    //        Console.WriteLine(customer.Orders.Count);

    //        Console.ReadKey();
    //    }

    //    public class Person
    //    {
    //        private DateTime _birthdate;
    //        public void SetBirthdate(DateTime birthdate)
    //        {
    //            _birthdate = birthdate;
    //        }

    //        public DateTime GetBirthdate()
    //        {
    //            return _birthdate;
    //        }
    //    }

    //    static public void AccessModifiers()
    //    {
    //        Console.Clear();
    //        var person = new Person();
    //        person.SetBirthdate(new DateTime(1982, 1, 1));

    //        Console.WriteLine(person.GetBirthdate());

    //        Console.ReadKey();
    //    }



    //    static public void Properties()
    //    {

    //        Console.Clear();
    //        var person = new Person(new DateTime(1982, 1, 1));

    //        Console.WriteLine(person.Age);

    //        Console.ReadKey();
    //    }

    //    static public void Indexers()
    //    {
    //        Console.Clear();

    //        var cookie = new HttpCookie();
    //        cookie["name"] = "Mosh";
    //        Console.WriteLine(cookie["name"]);



    //        Console.ReadKey();
    //    }

    //}
