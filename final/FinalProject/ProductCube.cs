using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ProductCube : Cube
    {
        public ProductCube(int number, double price, bool available) : base(number, price, available) { }

        public override string ToString()
        {
            return $"Product cube {base.ToString()}";
        }

    }

}
