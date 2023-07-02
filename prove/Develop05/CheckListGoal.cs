using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class CheckListGoal : Goal
    {
        private int _timesToComplete;
        private int _bonusPoints;
        private int _timesCompleted;
        public CheckListGoal(string name, string description, int points,int timesCompleted, int timesToComplete, int bonusPoints, bool isCompleted) : base(name, description, points, isCompleted)
        {
            _timesCompleted = timesCompleted;
            _timesToComplete = timesToComplete;
            _bonusPoints = bonusPoints;
        }

        public override int RecordEvent()
        {
            if (!_isCompleted)
            _timesCompleted++;
            if (_timesCompleted == _timesToComplete)
            {
                _isCompleted = true;
                return base.RecordEvent() + _bonusPoints;
            }
            else
                return base.RecordEvent();
        }
        public override string ToString()
        {
            return $"{base.ToString()} --- Currently completed {_timesCompleted}/{_timesToComplete}";
        }
        public override string StringToFile()
        {
            return $"3|{base.StringToFile()}|{_timesCompleted}|{_timesToComplete}|{_bonusPoints}";
        }
    }
}
