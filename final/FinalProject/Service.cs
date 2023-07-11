using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Service : Product
    {
        private string _provider;
        public Service(string name, string description, double price, string provider) : base(name, description, price)
        {
            _name = name;
            _description = description;
            _price = price;
            _provider = provider;
        }
        public override string ToString()
        {
            if (_idCube == 0)
            {
                return $"Service: {_name}, {_description} by {_provider}, price: ${_price}";
            }
            else
            {
                return $"Service: {_name}, {_description} by {_provider}, price: ${_price}, assigned cube: #{_idCube}";
            }
        }
    }
}
