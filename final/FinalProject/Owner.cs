using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Owner : Person
    {
        public List<Cube> _cubeList = new List<Cube>();
        public Owner(string name, string email, string phone, int id) : base(name, email, phone,id)
        {
            _cubeList = new List<Cube>();
        }
        public override void AddCube(Cube cube)
        {
            _cubeList.Add(cube);
        }

        public override string ToString()
        {
            return $"Owner's info: {base.ToString()}, Id: {_id}";
        }
    }
}
