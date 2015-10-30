using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class ButtonModel
    {
        bool CheckIfCorrect;
        bool YesOrNo;
        int correctstreak;

        public int correctStreak
        {
            get
            {
                return correctstreak;
            }
            set
            {
                correctstreak = value;
            }
        }
        public bool checkIfCorrect
        {
            get
            {
                return CheckIfCorrect;
            }
            set
            {
                CheckIfCorrect = value;
            }
        }
        public bool yesOrNo
        {
            get
            {
                return YesOrNo;
            }
            set
            {
                YesOrNo = value;
            }
        }
        }
}
