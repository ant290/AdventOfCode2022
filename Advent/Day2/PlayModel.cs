using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class PlayModel
    {
        public int WinVal = 6;
        public int DrawVal = 3;
        public int LoseVal = 0;

        public Dictionary<string, int> HandPointsDict = new Dictionary<string, int>()
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 3 },
            { "X", 1 },
            { "Y", 2 },
            { "Z", 3 }
        };

        public int MyScore;
        public char TheirHand;
        public char MyHand;

        public PlayModel(char theirHand, char myHand)
        {
            TheirHand = theirHand;
            MyHand = myHand;

            MyScore = CalculateMyScore();
        }

        private int CalculateMyScore()
        {
            switch (TheirHand)
            {
                case 'A':
                    switch (MyHand)
                    {
                        case 'X':
                            return HandPointsDict["X"] + DrawVal;
                        case 'Y':
                            return HandPointsDict["Y"] + WinVal;
                        case 'Z':
                            return HandPointsDict["Z"];
                        default:
                            return 0;
                    }
                case 'B':
                    switch (MyHand)
                    {
                        case 'X':
                            return HandPointsDict["X"];
                        case 'Y':
                            return HandPointsDict["Y"] + DrawVal;
                        case 'Z':
                            return HandPointsDict["Z"] + WinVal;
                        default:
                            return 0;
                    }
                case 'C':
                    switch (MyHand)
                    {
                        case 'X':
                            return HandPointsDict["X"] + WinVal;
                        case 'Y':
                            return HandPointsDict["Y"];
                        case 'Z':
                            return HandPointsDict["Z"] + DrawVal;
                        default:
                            return 0;
                    }
                default:
                    return 0;
            }
        }
    }

}
