using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cosmetic : Product
    {
        private string _quantity;
        public Cosmetic(string name, string description, string brand, double price, int stock, string quantity) : base(name, description, brand, price, stock)
        {
            _quantity = quantity;
        }
        public override string ToString()
        {
            return $"Product: {_name} by {_brand}, {_description}, size: {_quantity}, price ${_price}, stock: {_stock}";
        }
    }
}
