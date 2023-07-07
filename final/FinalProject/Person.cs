using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Person
    {
        public string _name;
        public string _email;
        public string _phone;
        public int _id;
        public Person(string name, string email, string phone, int id)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _id = id;
        }
        public virtual void AddCube(Cube cube)
        {

        }

        public override string ToString()
        {
            return $"{_name}, Email: {_email}, Phone: {_phone}, Id: {_id}";
        }

    }
}
