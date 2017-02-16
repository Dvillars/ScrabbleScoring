using System;
using System.Collections.Generic;

namespace ScrabbleCalc.Objects
{
    public class Scrabble
    {
        private int _score;

        public Scrabble(string input)
        {
            if(input == "A" || input == "E" || input == "I" || input == "O" || input == "U" || input == "L" || input == "N" || input == "R" || input == "S" || input == "T")
            {
                _score = 1;
            }
            else if (input == "D" || input == "G")
            {
                _score = 2;
            }
            else if(input == "B" || input == "C" || input == "M" || input == "P")
            {
                _score = 3;
            }
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
