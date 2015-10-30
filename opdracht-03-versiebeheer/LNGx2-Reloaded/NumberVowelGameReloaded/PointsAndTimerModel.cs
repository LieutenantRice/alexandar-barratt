using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class PointsAndTimerModel
    {

        int score;
        int Counter;
        int highscore;
        int _minutes;
        int _seconds;
        string _Minutes;
        string _Seconds;
        bool Start;

        public bool start
        {
            get
            {
                return Start;
            }
            set
            {
                Start = value;
            }
        }
        public string Seconds
        {
            get
            {
                return _Seconds;
            }
            set
            {
                _Seconds = value;
            }
        }
        public string Minutes
        {
            get
            {
                return _Minutes;
            }
            set
            {
                _Minutes = value;
            }
        }
        public int seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                _seconds = value;
            }
        }
        public int minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                _minutes = value;
            }
        }

        public int highScore
        {
            get
            {
                return highscore;
            }
            set
            {
                highscore = value;
            }
        }
        public int counter
        {
            get
            {
                return Counter;
            }
            set
            {
                Counter = value;
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
    }
}
