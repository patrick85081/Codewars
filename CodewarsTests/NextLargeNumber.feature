Feature: NextLargeNumber
	In order 將數字重新組合 
	As a user 
	I want to 取得重組下一個較大的數字，如果無法重組出更大的數字回傳-1

Scenario Outline: 取得下一個重組數字
	Given 當我輸入 <Input>
	When 重組後
	Then 應該為 <Excepted>

Examples:
| Input      | Excepted   |
| 1          | -1         |
| 12         | 21         |
| 21         | -1         |
| 345        | 354        |
| 576        | 657        |
| 2017       | 2071       |
| 2071       | 2107       |
| 123456789  | 123456798  |
| 1234567890 | 1234567908 |
| 1495941256 | 1495941265 |
| 404703381  | 404703813  |
