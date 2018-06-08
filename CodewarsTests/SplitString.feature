Feature: SplitString
	將輸入字串分成兩個一組，
	如果字串包含奇數個字元，則以'_'代替缺少的字元
	https://www.codewars.com/kata/split-strings/train/csharp

@mytag
Scenario: 字元數為偶數
	Given 輸入字元 abcdef
	When 進行字元切割
	Then 我會得到 ab,cd,ef
	
Scenario: 字元數為奇數
	Given 輸入字元 abc
	When 進行字元切割
	Then 我會得到 ab,c_