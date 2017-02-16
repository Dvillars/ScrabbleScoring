using System;
using System.Collections.Generic;

namespace ScrabbleCalc.Objects
{
    public class Scrabble
    {
        private int _score;

        public Scrabble(string input)
        {
            string uppercaseInput = input.ToUpper();
            char[] inputArray = uppercaseInput.ToCharArray();

            foreach(char charInput in inputArray)
            {
                if (charInput == 'A' || charInput == 'E' || charInput == 'I' || charInput == 'O' || charInput == 'U' || charInput == 'L' || charInput == 'N' || charInput == 'R' || charInput == 'S' || charInput == 'T')
                {
                    _score += 1;
                }
                else if (charInput == 'D' || charInput == 'G')
                {
                    _score += 2;
                }
                else if (charInput == 'B' || charInput == 'C' || charInput == 'M' || charInput == 'P')
                {
                    _score += 3;
                }
                else if (charInput == 'F' || charInput == 'H' || charInput == 'V' || charInput == 'W' || charInput == 'Y')
                {
                    _score += 4;
                }
                else if (charInput == 'K')
                {
                    _score += 5;
                }
                else if (charInput == 'J' || charInput == 'X')
                {
                    _score += 8;
                }
                else if (charInput == 'Q' || charInput == 'Z')
                {
                    _score += 10;
                }
                else
                {
                    _score += 0;
                }
            }
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
