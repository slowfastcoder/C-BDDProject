Feature: SampleTable
	Simple calculator for adding two numbers

@mytag
Scenario: Create a new employee with mandatary details
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory fields in the form
	 | Name  | Age | Phone      | Email                      |
	 | Apple | 99  | 1800123456 | apple@automatetheworld.com |
	#And I click the save button
	#Then I should see all the details saved in my application

Scenario Outline: Create a new employee with mandatary details using table
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory fields in the form <Name>, <Age> and <Phone>
	 | Name    | Age | Phone        | Email                         |
	 | Apple   | 99  | 1800123456   | apple@automatetheworld.com    |
	 | Orange  | 100 | 18006214541  | Orange@automatetheworld.com   |
	 | Muhamad | 500 | 180052145126 | Muahamad@automatetheworld.com | 
	#And I click the save button
	#Then I should see all the details saved in my application