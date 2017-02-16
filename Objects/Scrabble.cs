using System;
using System.Collections.Generic;

namespace ScrabbleCalc.Objects
{
    public class Scrabble
    {
        private int _score;

        public Scrabble(string input)
        {
            if(input == "A")
            {
                _score = 1;
            }
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
