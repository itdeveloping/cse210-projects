using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted)
        {

        }
        public override string StringToFile()
        {
            return $"1|{_name}|{_description}|{_points}|{_isCompleted}";
        }
        public override int RecordEvent()
        {
            _isCompleted = true;
            return base.RecordEvent();
        }


    }
    
}
