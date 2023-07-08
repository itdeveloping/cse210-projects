using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Clothe : Product
    {
        
        private string _size;
        public Clothe(string name, string description, string brand, double price, int stock, string size) : base(name, description, brand, price, stock)
        {
            _size = size;
        }
        public override void DeleteProduct()
        {
            
        }
        public override void ListProduct()
        {
            
        }

        public override string ToString()
        {
            return $"{_name} by {_brand}, {_description}, size: {_size}, price ${_price}, stock: {_stock}";
        }
    }
}
