using System;
using Xunit;
using System.Collections.Generic;
using ScrabbleCalc.Objects;

namespace ScrabbleCalc
{
    public class ScrabbleCalcTest
    {
        [Fact]
        public void IsScrabble_ScoreOfLetter_1()
        {
            //Arrange
            string inputTest = "A";
            int resultTest = 1;

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            int result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }
    }
}
