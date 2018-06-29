Feature: SumStrings
	提供兩數值字串進行相加
	結果回傳相加後的數字字串
	http://www.codewars.com/kata/sum-strings-as-numbers/train/csharp

Scenario: 符號測試
	Given 第一個數字 ,
	And 第二個數字 5
	When 進行相加
	Then 結果應為 5

Scenario: 進位測試
	Given 第一個數字 9999999999
	And 第二個數字 1111111111
	When 進行相加
	Then 結果應為 11111111110

Scenario: 超過UInt64的數字相加
	Given 第一個數字 712569312664357328695151392
	And 第二個數字 8100824045303269669937
	When 進行相加
	Then 結果應為 712577413488402631964821329


Scenario: 超過Decimal的數字相加
	Given 第一個數字 50095301248058391139327916261
	And 第二個數字 81055900096023504197206408605
	When 進行相加
	Then 結果應為 131151201344081895336534324866
