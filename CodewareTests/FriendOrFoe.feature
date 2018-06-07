Feature: FriendOrFoe
	找出好友名單內名字長度為4的好友
	https://www.codewars.com/kata/friend-or-foe/train/csharp


Scenario: 測試案例1
	Given 輸入好友名單 'Ryan,Kieran,Jason,Yous'
	When 進行篩選
	Then 得到 'Ryan,Yous'

Scenario: 測試案例2
	Given 輸入好友名單 'Ryan,Kieran,Mark,Jimmy'
	When 進行篩選
	Then 得到 'Ryan,Mark'