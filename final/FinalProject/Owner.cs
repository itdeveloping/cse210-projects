using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Owner : Person
    {
        public List<Cube> _cubeList = new List<Cube>();
        public Owner( int id,string name, string email, string phone) : base(id,name, email, phone)
        {
            _cubeList = new List<Cube>();
        }

        public override string ToString()
        {
            return $"Owner's info: {base.ToString()}";
        }
    }
}
