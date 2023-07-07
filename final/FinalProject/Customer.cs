using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Customer : Person
    {
        public Customer(string name, string email, string phone, int id) : base(name, email, phone,id)
        {
        }
        public override string ToString()
        {
            return $"Customer info: {base.ToString()}, Id: {_id}";
        }

    }
}
