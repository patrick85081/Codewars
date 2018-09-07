Feature: GetSum
	輸入兩個數字
	加總之間的所有數字
	https://www.codewars.com/kata/beginner-series-number-3-sum-of-numbers/train/csharp

Scenario: 數字1 to 0 加總
	Given 開始數字： 1, 結束數字 0
	When 開始計算
	Then 結果為 1

Scenario: 數字1 to 2 加總
	Given 開始數字： 1, 結束數字 2
	When 開始計算
	Then 結果為 3
	
Scenario: 數字0 to 1 加總
	Given 開始數字： 0, 結束數字 1
	When 開始計算
	Then 結果為 1
	
Scenario: 數字1 to 1 加總
	Given 開始數字： 1, 結束數字 1
	When 開始計算
	Then 結果為 1
	
Scenario: 數字 -1 to 0 加總
	Given 開始數字： -1, 結束數字 0
	When 開始計算
	Then 結果為 -1
	
Scenario: 數字 -1 to 2 加總
	Given 開始數字： -1, 結束數字 2
	When 開始計算
	Then 結果為 2

Scenario: 數字 -1 to 1 加總
	Given 開始數字： -1, 結束數字 1
	When 開始計算
	Then 結果為 0