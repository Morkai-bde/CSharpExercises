using System.Collections.Generic;

namespace Exercises.Exercises.Intermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //
        }

    }
}
