# __*Scrabble Calculator*__

## By Lawrence Eby, Grinil Khanna, and Derek Villars

## Description

This is a basic scrabble score calculator. It won't calculate the board condition, but will tell you the base score of each word.

## Specs

1. The program should take a single letter and output the score of that letter for scores of 1.
  * **Input:** "A"
  * **Output:** "1"
1. The program should take a single letter and output the score of that letter for scores of 2.
  * **Input:** "D"
  * **Output:** "2"
1. The program should take a single letter and output the score of that letter for scores of 3.
  * **Input:** "B"
  * **Output:** "3"
1. The program should take a single letter and output the score of that letter for scores of 4.
  * **Input:** "F"
  * **Output:** "4"
1. The program should take a single letter and output the score of that letter for scores of 5.
  * **Input:** "K"
  * **Output:** "8"
1. The program should take a single letter and output the score of that letter for scores of 8.
  * **Input:** "J"
  * **Output:** "8"
1. The program should take a single letter and output the score of that letter for scores of 10.
  * **Input:** "Q"
  * **Output:** "10"
1. The program should take a single letter regardless of case and output the score of that letter.
  * **Input:** "a"
  * **Output:** "1"
- The program should take a string of letters, and output the score total.
  * **Input:** "AAAAz"
  * **Output:** 14
- The program should be limited to one word at a time.
  * **Input:** "About time"
  * **Output:** "Please enter a single word with no special characters"


## Key
|Letter|Value|
|------|:-----:|
|A, E, I, O, U, L, N, R, S, T|1|
|D, G|2|
|B, C, M, P|3|
|F, H, V, W, Y|4|
|K|5|
|J, X|8|
|Q, Z|10|
