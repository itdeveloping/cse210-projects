using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Product
    {
        protected string _brand, _name, _description;
        protected double _price;
        protected int _stock;
        protected int _idCube;
        public Product( string brand, string name, string description, double price, int stock)
        {
            _brand = brand;
            _name = name;
            _description = description;
            _price = price;
            _stock = stock;
        }

        public string GetName()
        {
            return _name; 
        }
        public void AssignCube(int idCube)
        {
            _idCube = idCube;
        }
        public int GetIdCube()
        { return _idCube; }

        public Product(string name, string description, double price) // for service sub class
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public override string ToString()
        {
            if (_idCube == 0)
                return $"{_name} by {_brand}, {_description}, price ${_price}, stock: {_stock}";
            else
                return $"{_name} by {_brand}, {_description}, price ${_price}, stock: {_stock}, assigned cube: #{_idCube}";
        }
    }
}
