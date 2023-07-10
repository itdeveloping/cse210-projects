using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Cube
    {
        protected int _idCube;
        protected double _price;
        protected bool _available;
        protected string _ownerName;
        protected string _serviceName;
        public Cube(int number, double price, bool available)
        {
            _idCube = number;
            _price = price;
            _available = available;
            _ownerName = null;
        }
        public int GetIdCube()
        { 
            return _idCube; 
        }
        public virtual void SetPrice(double price)
        {
            _price = price;
        }
        public string GetOwnerName()
        {
            return _ownerName;
        }
        public virtual void AddOwner(string ownerName)
        {
            _ownerName = ownerName;
            _available = false;
        }
        public virtual void AddService(string serviceName)
        {
            _serviceName = serviceName;
        }

        public void Release()
        {
            _available = true;
            _ownerName = null;
            _serviceName = null;
        }

        public bool IsAvailable()
        {
            return _available;
        }

        public void List(List<Cube> _cubeList)
        {
            _cubeList.Sort(delegate (Cube x, Cube y)
            {
                return x._idCube.CompareTo(y._idCube);
            });
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
