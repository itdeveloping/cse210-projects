using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Person
    {
        protected string _name;
        protected string _email;
        protected string _phone;
        protected int _id;
        public Person(int id, string name, string email, string phone)
        {
            _id = id;
            _name = name;
            _email = email;
            _phone = phone;
        }
        public string GetName()
        { return _name; }
        public int GetId()
        { return _id; }
        public void SetData(string name, string email, string phone)
        {
            _name = name;
            _email = email;
            _phone = phone;

        }
        public override string ToString()
        {
            return $" Id: {_id}, {_name}, Email: {_email}, Phone: {_phone}";
        }

    }
}
