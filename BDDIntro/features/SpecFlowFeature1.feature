Feature: Logon

Scenario: Cancel Logon
	Given I start AccountRight
	Then I should see the signon Window
	When I cancel sign on
	Then I should see the library browser
