using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Customer : Person
    {
        public Customer( int id,string name, string email, string phone) : base(id,name, email, phone)
        {
        }
        public override string ToString()
        {
            return $"Customer info: {base.ToString()}";
        }

    }
}
