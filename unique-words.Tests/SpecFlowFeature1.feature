Feature: CountText

Scenario: countSimpleText
	Given I am on the page 
	And I enter text "Some text here. Here"
	When I press submit
	Then the output should contain "some: 1"
	And the output should contain "text: 1"
	And the output should contain "here: 2"