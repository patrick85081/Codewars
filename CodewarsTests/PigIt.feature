Feature: PigIt
	In order 文字編碼規則，每一個單字第一個字移動到最後面，並加上ay
	As a User
	I want to 將一段話，進行編碼

Scenario Outline: 文字解碼
	Given 輸入 <Input>
	When 進行轉換
	Then 應該為 <Expected>

Examples: 
| Input             | Expected                  |
| Patrick           | atrickPay                 |
| Pig latin is cool | igPay atinlay siay oolcay |
| This is my string | hisTay siay ymay tringsay |
