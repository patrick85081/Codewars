Feature: DeclareWinner
	創建一個函數，返回兩名戰士之間的戰鬥中贏家的名字。
	每個戰鬥機輪流攻擊另一個，誰先殺死另一個誰是勝利的。 死亡被定義為健康<= 0。

@DeclareWinner
Scenario: 戰鬥案例1
	Given 第一名戰士 Lew, 生命 10, 攻擊 2 
	And 第二名戰士 Harry, 生命 5, 攻擊 4
	When 由 Lew 先攻
	Then 戰鬥結果 Lew 獲勝

Scenario: 戰鬥案例2
	Given 第一名戰士 Lew, 生命 10, 攻擊 2 
	And 第二名戰士 Harry, 生命 5, 攻擊 4
	When 由 Harry 先攻
	Then 戰鬥結果 Harry 獲勝

Scenario: 戰鬥案例3
	Given 第一名戰士 Harald, 生命 20, 攻擊 5 
	And 第二名戰士 Harry, 生命 5, 攻擊 4
	When 由 Harry 先攻
	Then 戰鬥結果 Harald 獲勝

Scenario: 戰鬥案例4
	Given 第一名戰士 Harald, 生命 20, 攻擊 5 
	And 第二名戰士 Harry, 生命 5, 攻擊 4
	When 由 Harald 先攻
	Then 戰鬥結果 Harald 獲勝

Scenario: 戰鬥案例5
	Given 第一名戰士 Jerry, 生命 30, 攻擊 3 
	And 第二名戰士 Harald, 生命 20, 攻擊 5 
	When 由 Jerry 先攻
	Then 戰鬥結果 Harald 獲勝

Scenario: 戰鬥案例6
	Given 第一名戰士 Jerry, 生命 30, 攻擊 3 
	And 第二名戰士 Harald, 生命 20, 攻擊 5 
	When 由 Harald 先攻
	Then 戰鬥結果 Harald 獲勝

	Scenario: 戰鬥案例7
	Given 第一名戰士 Jerry, 生命 40, 攻擊 3 
	And 第二名戰士 Harald, 生命 20, 攻擊 5 
	When 由 Harald 先攻
	Then 戰鬥結果 Jerry 獲勝