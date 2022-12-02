namespace Day2
{
    public class PlayModel
    {
        public const int WinVal = 6;
        public const int DrawVal = 3;
        public const int LoseVal = 0;

        public const char LoseChar = 'X';
        public const char DrawChar = 'Y';
        public const char WinChar = 'Z';

        public const char RockChar = 'A';
        public const char PaperChar = 'B';
        public const char ScissorsChar = 'C';

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

        public PlayModel(char theirHand, char requiredResult)
        {
            TheirHand = theirHand;
            MyHand = HandToPlay(requiredResult);

            MyScore = CalculateMyScore();
        }

        private char HandToPlay(char requiredResult)
        {
            switch (TheirHand)
            {
                case RockChar:
                    switch (requiredResult)
                    {
                        case LoseChar:
                            return ScissorsChar;
                        case DrawChar:
                            return RockChar;
                        case WinChar:
                            return PaperChar;
                        default:
                            return '0';
                    }
                case PaperChar:
                    switch (requiredResult)
                    {
                        case LoseChar:
                            return RockChar;
                        case DrawChar:
                            return PaperChar;
                        case WinChar:
                            return ScissorsChar;
                        default:
                            return '0';
                    }
                case ScissorsChar:
                    switch (requiredResult)
                    {
                        case LoseChar:
                            return PaperChar;
                        case DrawChar:
                            return ScissorsChar;
                        case WinChar:
                            return RockChar;
                        default:
                            return '0';
                    }
                default:
                    return '0';
            }
        }

        private int CalculateMyScore()
        {
            switch (TheirHand)
            {
                case RockChar:
                    switch (MyHand)
                    {
                        case RockChar:
                            return HandPointsDict["X"] + DrawVal;
                        case PaperChar:
                            return HandPointsDict["Y"] + WinVal;
                        case ScissorsChar:
                            return HandPointsDict["Z"];
                        default:
                            return 0;
                    }
                case PaperChar:
                    switch (MyHand)
                    {
                        case RockChar:
                            return HandPointsDict["X"];
                        case PaperChar:
                            return HandPointsDict["Y"] + DrawVal;
                        case ScissorsChar:
                            return HandPointsDict["Z"] + WinVal;
                        default:
                            return 0;
                    }
                case ScissorsChar:
                    switch (MyHand)
                    {
                        case RockChar:
                            return HandPointsDict["X"] + WinVal;
                        case PaperChar:
                            return HandPointsDict["Y"];
                        case ScissorsChar:
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
