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
	
Scenario: 輸入100
	Given 輸入 100 一組數字
	When 按下轉換
	Then 得到 one hundren .

Scenario: 輸入101
	Given 輸入 101 一組數字
	When 按下轉換
	Then 得到 one hundren one .

Scenario: 輸入150
	Given 輸入 150 一組數字
	When 按下轉換
	Then 得到 one hundren fifty .

Scenario: 輸入151
	Given 輸入 151 一組數字
	When 按下轉換
	Then 得到 one hundren fifty-one .

Scenario: 輸入1,000
	Given 輸入 1000 一組數字
	When 按下轉換
	Then 得到 one thousand .
	
Scenario: 輸入10,000
	Given 輸入 10000 一組數字
	When 按下轉換
	Then 得到 ten thousand .
	
Scenario: 輸入100,000
	Given 輸入 100000 一組數字
	When 按下轉換
	Then 得到 one hundren thousand .
	
Scenario: 輸入100,002
	Given 輸入 100002 一組數字
	When 按下轉換
	Then 得到 one hundren thousand two .
	
Scenario: 輸入99,999
	Given 輸入 99999 一組數字
	When 按下轉換
	Then 得到 ninety-nine thousand nine hundren ninety-nine .

Scenario: 輸入888,888
	Given 輸入 888888 一組數字
	When 按下轉換
	Then 得到 eight hundren eighty-eight thousand eight hundren eighty-eight .

