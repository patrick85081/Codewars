Feature: AlphabetPosition
	將輸入一段英文轉換成英文字母順序數字
	英文以外的字元忽略
	https://www.codewars.com/kata/replace-with-alphabet-position/train/csharp

@mytag
Scenario: 測試案例1
	Given 輸入一段英文 The sunset sets at twelve o' clock.
	When 開始轉換
	Then 得到 20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11

Scenario: 測試案例2
	Given 輸入一段英文 The narwhal bacons at midnight.
	When 開始轉換
	Then 得到 20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20