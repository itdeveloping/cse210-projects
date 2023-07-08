using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Product
    {
        public string _name;
        public string _description;
        public string _brand;
        public double _price;
        public int _stock;

        public Product(string name, string description) // for service sub class
        {
            _name = name;
            _description = description;
        }


        public Product(string name, string description, string brand, double price, int stock)
        {
            _name = name;
            _description = description;
            _brand = brand;
            _price = price;
            _stock = stock;

        }
        public virtual void DeleteProduct()
        {

        }
        
        public virtual void ListProduct()
        {

        }
        public override string ToString()
        {
            return $"{_name} by {_brand} , {_description}, price ${_price}, stock: {_stock}";
        }
    }
}
