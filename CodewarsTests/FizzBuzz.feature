Feature: FizzBuzz
	In order to 報數遊戲，三的倍數或數字有三報Fizz，五的倍數或數字有五報Buzz，十五的倍數報FizzBuzz
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
| 13    | Fizz     |
| 14    | 14       |
| 15    | FizzBuzz |
| 50    | Buzz     |
| 51    | FizzBuzz |
| 52    | Buzz     |
| 153   | FizzBuzz |
