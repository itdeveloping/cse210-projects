using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class Score
    {
        private int _score;
        public Score() { 
            _score = 0;
        }
        public void AddScore(int points)
        {
            _score += points;
        }
        public int GetScore()
        {
            return _score;
        }
    }
}
