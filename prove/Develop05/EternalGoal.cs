using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted)
        {

        }
        public override string StringToFile()
        {
            return $"2|{_name}|{_description}|{_points}|{_isCompleted}";
        }

    }
}
