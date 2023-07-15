using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Cube
    {
        protected int _idCube, _idOwner;
        protected double _price;
        protected bool _available;
        protected string _serviceName;
        protected List<int> _productList = new List<int>();
        public Cube(int number, double price, bool available)
        {
            _idCube = number;
            _price = price;
            _available = available;
            _idOwner = 0;
        }
        public int GetIdCube()
        { 
            return _idCube; 
        }
        public virtual void SetPrice(double price)
        {
            _price = price;
        }
        public int GetIdOwner()
        {
            return _idOwner;
        }
        public virtual void AddOwner(int idOwner)
        {
            _idOwner = idOwner;
            _available = false;
        }
        public virtual void AddService(string serviceName)
        {
            _serviceName = serviceName;
        }

        public void Release()

        {
            _available = true;
            _idOwner = 0;
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
            {
                Manager manager = new Manager();
                return $"#{_idCube}, Price: $ {_price:0.00}, Available: No, rented by: {manager.GetOwnerName(_idOwner)}";
            }
            
        }
    }
}
