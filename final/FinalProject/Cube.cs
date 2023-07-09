using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cube
    {
        public int _idCube;
        public double _price;
        protected bool _available;
        protected string _ownerName;
        public Cube(int number, double price, bool available)
        {
            _idCube = number;
            _price = price;
            _available = available;
            _ownerName = "";
        }

        public virtual void AddOwner(string ownerName)
        {
            _ownerName = ownerName;
            _available = false;
        }
        public virtual void AddService(string _serviceName) { }

        public void Release()
        {
            _available = true;
        }

        public bool IsAvailable()
        {
            return _available;
        }

        public override string ToString()
        {
            if (_available)

                return $"#{_idCube}, Price: $ {_price:0.00}, Available: Yes";
            else
                return $"#{_idCube}, Price: $ {_price:0.00}, Available: No, Owner: {_ownerName}";

        }
    }
}
