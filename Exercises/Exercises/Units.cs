using System;

namespace Exercises.Exercises
{
    internal class UnitsExercise
    {
        public UnitsExercise()
        {
            var archer = new Archer("Iymbryl");
            var archer2 = new Archer("Althidon");
            var footman = new Footman("Folen");
            var footman2 = new Footman("Cailu");
            System.Threading.Thread.Sleep(1000);
            footman.Greeting();
            System.Threading.Thread.Sleep(1000);
            footman.Attack(footman2);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(footman2.Name + " - " + footman2.Health+"/"+"10");
            System.Threading.Thread.Sleep(1000);
            archer.Attack(footman);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(footman.Name + " - " + footman.Health + "/" + "10");
            System.Threading.Thread.Sleep(1000);
            archer2.Attack(footman);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(footman.Name + " - " + footman.Health + "/" + "10");
            System.Threading.Thread.Sleep(1000);
            footman.Attack(footman2);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(footman2.Name + " - " + footman2.Health + "/" + "10");
            System.Threading.Thread.Sleep(1000);
            archer.Attack(footman);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(footman.Name + " - " + footman.Health + "/" + "10");
            System.Threading.Thread.Sleep(1000);
            archer2.Attack(footman);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(footman.Name + " - " + footman.Health + "/" + "10");
        }
    }
    public abstract class Unit : IDisposable
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Unit(string name)
        {
            Console.WriteLine(name + " Has entered combat");
            Name = name;
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello World, my name is {Name}");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                Dispose();
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Ugh!");
        }
    }
    public class Footman : Unit
    {
        public int Damage { get; set; }
        public Footman(string name) : base(name)
        {
            Damage = 5;
            Health = 10;
        }
        public void Attack(Unit target)
        {
            Console.WriteLine($"{Name} hits {target.Name} for {Damage} damage");
            target.TakeDamage(Damage);
        }
    }
    public class Archer : Unit
    {
        public int Damage { get; set; }
        public Archer(string name) : base(name)
        {
            Damage = 3;
            Health = 7;
        }
        public void Attack(Unit target)
        {
            Console.WriteLine($"{Name} shoots {target.Name} for {Damage} damage");
            target.TakeDamage(Damage);
        }
    }
}
