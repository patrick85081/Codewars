Feature: FizzBuzz
	In order to 報數遊戲，三個倍數報Fizz，五的倍數報Buzz，十五的倍數報FizzBuzz
	As a teacher
	I want to 讓我輸入一個數字，計算出需要報數用的字串

Scenario Outline: 報數測試，當我輸入
	Given 當我輸入 <Input>
	When 產生報數字串
	Then 得到 <Result>

Examples: 
| Input | Result   |
| 1     | 1        |
| 2     | 2        |
| 3     | Fizz     |
| 4     | 4        |
| 5     | Buzz     |
| 6     | Fizz     |
| 15    | FizzBuzz |