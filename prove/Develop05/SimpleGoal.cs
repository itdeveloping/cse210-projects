using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {

        }

        public override int RecordEvent()
        {
            _isCompleted = true;
            return base.RecordEvent();
        }


    }
    
}
