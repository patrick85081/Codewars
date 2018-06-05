Feature: Number2Words
	輸入一組數字，將輸入的數字轉換成英文
	https://www.codewars.com/kata/52724507b149fa120600031d/train/csharp

@mytag
Scenario: 輸入0
	Given 輸入 0 一組數字
	When 按下轉換
	Then 得到 zero .

Scenario: 輸入1
	Given 輸入 1 一組數字
	When 按下轉換
	Then 得到 one .

Scenario: 輸入3
	Given 輸入 3 一組數字
	When 按下轉換
	Then 得到 three .

Scenario: 輸入8
	Given 輸入 8 一組數字
	When 按下轉換
	Then 得到 eight .

Scenario: 輸入10
	Given 輸入 10 一組數字
	When 按下轉換
	Then 得到 ten .

Scenario: 輸入15
	Given 輸入 15 一組數字
	When 按下轉換
	Then 得到 fifteen .

Scenario: 輸入21
	Given 輸入 21 一組數字
	When 按下轉換
	Then 得到 twenty-one .

Scenario: 輸入25
	Given 輸入 25 一組數字
	When 按下轉換
	Then 得到 twenty-five .

Scenario: 輸入35
	Given 輸入 35 一組數字
	When 按下轉換
	Then 得到 thirty-five .

Scenario: 輸入99
	Given 輸入 99 一組數字
	When 按下轉換
	Then 得到 ninety-nine .