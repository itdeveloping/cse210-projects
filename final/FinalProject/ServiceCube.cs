using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ServiceCube : Cube
    {
        private string _serviceName;
        public ServiceCube(int number, double price, bool available) : base(number, price, available)
        {
            _serviceName = "";
        }

        public override void AddService( string serviceName)
        {
            _serviceName = serviceName;

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
