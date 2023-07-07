using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Service : Product
    {
        private string _provider;
        public Service(string name, string description, string provider) :base (name, description)
        { 
            _name = name;
            _description = description;
            _provider = provider;
        }
        public override string ToString()
        {
            return $"Service: {_name} {_description}, provider: {_provider}";
        }
    }
}
