using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Cosmetic : Product
    {
        private string _quantity;
        public Cosmetic( string brand, string name, string description, double price, int stock, string quantity) : base( brand, name, description, price, stock)
        {
            _quantity = quantity;
        }
        public override string ToString()
        {
            if (_idCube == 0)
            {
                return $"Cosmetic: {base.ToString()}, quantity: {_quantity}";
            }
            else
            {
                return $"{_name} by {_brand}, {_description}, price ${_price}, stock: {_stock}, quantity: {_quantity}, assigned cube: #{_idCube}";
            }

        }
    }
}
