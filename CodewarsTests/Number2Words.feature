Feature: Number2Words
	輸入一組數字，將輸入的數字轉換成英文
	https://www.codewars.com/kata/52724507b149fa120600031d/train/csharp

Scenario Outline: 輸入
	Given 輸入 <Number> 一組數字
	When 按下轉換
	Then 得到 <Word> .

Examples: 
| Number | Word                                                           |
| 0      | zero                                                           |
| 1      | one                                                            |
| 3      | three                                                          |
| 8      | eight                                                          |
| 10     | ten                                                            |
| 15     | fifteen                                                        |
| 21     | twenty-one                                                     |
| 25     | twenty-five                                                    |
| 35     | thirty-five                                                    |
| 99     | ninety-nine                                                    |
| 100    | one hundred                                                    |
| 101    | one hundred one                                                |
| 150    | one hundred fifty                                              |
| 151    | one hundred fifty-one                                          |
| 1000   | one thousand                                                   |
| 10000  | ten thousand                                                   |
| 100000 | one hundred thousand                                           |
| 100002 | one hundred thousand two                                       |
| 99999  | ninety-nine thousand nine hundred ninety-nine                  |
| 888888 | eight hundred eighty-eight thousand eight hundred eighty-eight |