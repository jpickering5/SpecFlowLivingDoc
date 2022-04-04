Feature: As a StockApp user I want to purchase a given amount of stock at the latest value so that I can increase the value of my portfolio

@mytag
Scenario: As a StockApp user I want to purchase a given amount of stock at the latest value so that I can increase the value of my portfolio
	Given That I am a StockApp user
	And My initial portfolio has a value of '<Initial Portfolio Value>'
	When I purchase '<AmountOfStockToBuy>' amount of '<StockCode>' at the latest value
	Then My portfolio has increased in value when compared with '<Initial Portfolio Value>'
	Examples: 
	| Initial Portfolio Value | AmountOfStockToBuy | StockCode |
	| 1500                    | 10                 | MSFT      |
	| 0                       | 5                  | SBUX      |
	| 100                     | 3                  | AMZN      |
	| 25000                   | 8                  | BA        |