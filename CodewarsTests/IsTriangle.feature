Feature: IsTriangle
	輸入三個邊長
	回傳是否可以組成三角形
	https://www.codewars.com/kata/is-this-a-triangle/train/csharp

Scenario: 三角形案例1
	Given 我有三個邊長 5, 7, 10
	When 判斷是否可以組成三角形
	Then 結果為 true

Scenario: 三角形案例2
	Given 我有三個邊長 -1, 2, 3
	When 判斷是否可以組成三角形
	Then 結果為 false

Scenario: 三角形案例3
	Given 我有三個邊長 1, 2, 4
	When 判斷是否可以組成三角形
	Then 結果為 false
