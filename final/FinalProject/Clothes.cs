using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Clothes : Product
    {

        private string _size;
        public Clothes(string brand, string name, string description, double price, int stock, string size) : base(brand, name, description, price, stock)
        {
            _size = size;
        }

        public override string ToString()
        {
            if (_idCube == 0)
            {
                return $"Clothes: {base.ToString()}, size: {_size}";
            }
            else
            {
                return $"{_name} by {_brand}, {_description}, price ${_price}, stock: {_stock}, size: {_size}, assigned cube: #{_idCube}";
            }
        }
    }
}
