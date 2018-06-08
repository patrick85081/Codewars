Feature: PrinterError
	我們有一台印表機，列印的字元只會有a ~ m
	請寫一個函數檢查列印出來的結果 分析以 錯誤字元數/總字元數 方式回傳
	https://www.codewars.com/kata/printer-errors/train/csharp

@mytag
Scenario: 完美的列印
	Given 我的印表機列印出 aaabbbbhaijjjm
	When 進行分析
	Then 結果為 0/14
	
Scenario: 有錯誤的列印1
	Given 我的印表機列印出 aaaxbbbbyyhwawiwjjjwwm
	When 進行分析
	Then 結果為 8/22

Scenario: 有錯誤的列印2
	Given 我的印表機列印出 aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz
	When 進行分析
	Then 結果為 3/56