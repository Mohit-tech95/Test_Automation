Feature: GoogleSearchFeature
	In order to test search functionality on Google
	As part of Automation Test
	I want to test if search funtionality is working 

@GoogleSearch
Scenario: Google should search for the given keyword and should navigate to the search results
	Given I have navigated to the google serach page
	And I have entered Selenium as search keyword input
	When I have searched the input keyword
	Then I should be navigated to seatch result page