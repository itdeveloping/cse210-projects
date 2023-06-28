using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public  class CheckListGoal : Goal
    {
        private int _timesToComplete;
        private int _bonusPoints;
        private int _timesCompleted;
        public CheckListGoal(string name, string description, int points, int timesToComplete, int bonusPoints) : base( name,  description,  points)
        {
            _timesToComplete = timesToComplete;
            _bonusPoints = bonusPoints;
        }

        public override int RecordEvent()
        {
            _timesCompleted++;
            if (_timesCompleted == _timesToComplete)
                return base.RecordEvent() + _bonusPoints;
            else
                return base.RecordEvent();
        }
        public override string ToString()
        {
            return $"{base.ToString()} {_timesCompleted}/{_timesToComplete}";
        }
    }
}
