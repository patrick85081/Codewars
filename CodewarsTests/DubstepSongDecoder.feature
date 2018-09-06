Feature: DubstepSongDecoder
	https://www.codewars.com/kata/dubstep/train/csharp
	In order 還原音樂
	As Json
	I want to 將混有 WUB 的音樂恢復原始歌曲

@mytag
Scenario: 原始歌曲 A
	Given 我有一首混音音樂 WUBAWUB
	When 音樂還原
	Then 得到原始音樂 A

Scenario: 原始歌曲 ABC
	Given 我有一首混音音樂 WUBWUBABCWUB
	When 音樂還原
	Then 得到原始音樂 ABC

Scenario: 原始歌曲 R L
	Given 我有一首混音音樂 RWUBWUBWUBLWUB
	When 音樂還原
	Then 得到原始音樂 R L
	
Scenario: 原始歌曲 WE ARE THE CHAMPIONS MY FRIEND
	Given 我有一首混音音樂 WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB
	When 音樂還原
	Then 得到原始音樂 WE ARE THE CHAMPIONS MY FRIEND
