Feature: MakeComplement
	在DNA字串中，'A'與'T'是互補、'C'和'G'也是
	請寫一個函數取得輸入DNA字串的互補的那一面
	想知道更多DNA知識：http://en.wikipedia.org/wiki/DNA
	https://www.codewars.com/kata/complementary-dna/train/csharp

@mytag
Scenario: DNA案例1
	Given 我有一個DNA字串 ATTGC
	When 取得互補面
	Then 我應該得到 TAACG
	
Scenario: DNA案例2
	Given 我有一個DNA字串 GTAT
	When 取得互補面
	Then 我應該得到 CATA
	
Scenario: DNA案例3
	Given 我有一個DNA字串 TTTT
	When 取得互補面
	Then 我應該得到 AAAA
	
Scenario: DNA案例4
	Given 我有一個DNA字串 TAACG
	When 取得互補面
	Then 我應該得到 ATTGC
	
Scenario: DNA案例5
	Given 我有一個DNA字串 CATA
	When 取得互補面
	Then 我應該得到 GTAT