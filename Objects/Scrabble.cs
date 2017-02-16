using System;
using System.Collections.Generic;

namespace ScrabbleCalc.Objects
{
    public class Scrabble
    {
        private int _score;

        public Scrabble(string input)
        {
            string userInput = input.ToUpper();
            if (userInput == "A" || userInput == "E" || userInput == "I" || userInput == "O" || userInput == "U" || userInput == "L" || userInput == "N" || userInput == "R" || userInput == "S" || userInput == "T")
            {
                _score = 1;
            }
            else if (userInput == "D" || userInput == "G")
            {
                _score = 2;
            }
            else if (userInput == "B" || userInput == "C" || userInput == "M" || userInput == "P")
            {
                _score = 3;
            }
            else if (userInput == "F" || userInput == "H" || userInput == "V" || userInput == "W" || userInput == "Y")
            {
                _score = 4;
            }
            else if (userInput == "K")
            {
                _score = 5;
            }
            else if (userInput == "J" || userInput == "X")
            {
                _score = 8;
            }
            else if (userInput == "Q" || userInput == "Z")
            {
                _score = 10;
            }
            else
            {
                _score = 0;
            }
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
