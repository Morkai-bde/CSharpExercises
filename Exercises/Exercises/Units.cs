using System;

namespace Exercises.Exercises
{
    internal class UnitsExercise
    {
        public UnitsExercise()
        {
            // var unit = new Unit("Iymbryl");
            // var unit2 = new Unit("Althidon");
            // unit2.Greeting();
            var footman = new Footman("Folen");
            var footman2 = new Footman("Cailu");
            footman.Greeting();
            footman.Attack(footman2);
            Console.WriteLine(footman2.Health);
            footman.Attack(footman2);
            Console.WriteLine(footman2.Health);
        }
    }
    public abstract class Unit : IDisposable
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Unit(string name)
        {
            Console.WriteLine("Unit Created");
            Name = name;
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello World, my name is {Name}");
        }

        public void TakeDamage(int damage)
        {
            Health = Health - damage;
            if (Health <= 0)
            {
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
            Console.WriteLine($"{Name} does {Damage} Damage to {target.Name}");
            target.TakeDamage(Damage);
        }
    }
}
