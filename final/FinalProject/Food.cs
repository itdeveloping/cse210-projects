using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Food : Product
    {
        private DateOnly _bestBy = new();
        public Food(string name, string description, string brand, double price, int stock, DateOnly bestBy) : base(name, description, brand, price, stock)
        {
            _bestBy = bestBy;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, best by: {_bestBy}";
        }
    }
}
