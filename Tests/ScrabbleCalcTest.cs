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
            string inputTest = "E";
            string resultTest = "1";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_2()
        {
            //Arrange
            string inputTest = "D";
            string resultTest = "2";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_3()
        {
            //Arrange
            string inputTest = "B";
            string resultTest = "3";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_4()
        {
            //Arrange
            string inputTest = "F";
            string resultTest = "4";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_5()
        {
            //Arrange
            string inputTest = "K";
            string resultTest = "5";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_8()
        {
            //Arrange
            string inputTest = "J";
            string resultTest = "8";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLetter_10()
        {
            //Arrange
            string inputTest = "Z";
            string resultTest = "10";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfInvalidLetter_0()
        {
            //Arrange
            string inputTest = "!";
            string resultTest = "Please enter a single word with no special characters";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfLowerCaseLetter_1()
        {
            //Arrange
            string inputTest = "a";
            string resultTest = "1";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_ScoreOfString_6()
        {
            //Arrange
            string inputTest = "Hat";
            string resultTest = "6";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void IsScrabble_InvalidCharacter_phrase()
        {
            //Arrange
            string inputTest = "here is a test string";
            string resultTest = "Please enter a single word with no special characters";

            //Act
            Scrabble testCalc = new Scrabble(inputTest);
            string result = testCalc.GetScore();

            //Assert
            Assert.Equal(resultTest, result);
        }
    }
}
