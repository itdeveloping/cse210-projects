using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ServiceCube : Cube
    {
        public ServiceCube(int number, double price, bool available) : base(number, price, available)
        {
            _price  = price * 1.0825;// increase tax to service cubes
            _serviceName = null;
        }
        public override void SetPrice(double price)
        {
            _price = price * 1.0825; // increase tax to service cubes
        }

        public override string ToString()
        {
            if (_available)

                return $"Service cube {base.ToString()}";
            else
                return $"Service cube {base.ToString()}, Service description: {_serviceName}";

        }
    }
}
