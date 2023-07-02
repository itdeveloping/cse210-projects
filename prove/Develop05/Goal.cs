using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;
        protected bool _isCompleted;

        public Goal(string name, string description, int points, bool isCompleted)
        {
            _name = name;
            _description = description;
            _points = points;
            _isCompleted = isCompleted;
        }
        public override string ToString()
        {

            if (_isCompleted)
                return $"[x] {_name} ({_description}) ";
            else
                return $"[ ] {_name} ({_description}) ";

        }
        public virtual string StringToFile()
        {
            return $"{_name}|{_description}|{_points}|{_isCompleted}";
        }
        public virtual int RecordEvent()
        {
            
            return _points;
        }
    }
}
