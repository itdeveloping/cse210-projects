using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Food : Product
    {
        private DateTime _bestBy = new();
        public Food( string brand,string name, string description,  double price, int stock, DateTime bestBy) : base( brand,name, description,  price, stock)
        {
            _bestBy = bestBy;
        }
        public override string ToString()
        {
            if (_idCube == 0)
            {
                return $"Food: {base.ToString()}, best by: {_bestBy.ToString("dddd, dd MMMM yyyy")}";
            }
            else
            {
                return $"{_name} by {_brand}, {_description}, price ${_price}, stock: {_stock}, best by: {_bestBy.ToString("dddd, dd MMMM yyyy")}, assigned cube: #{_idCube}";
            }

        }
    }
}
