using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Manager
    {

        List<Cube> cubeList = new List<Cube>();
        Cube cubeObject;
        List<Product> productList = new List<Product>();
        Product productObject;
        List<Person> customerList = new List<Person>();
        Person customerObject;
        List<Person> ownerList = new List<Person>();
        Person ownerObject;
        Manager() { }

        public void AddCube()
        {

        }
        public void DeleteCube()
        {

        }
        public void ListCubes()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
