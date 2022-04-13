Feature: ChromeBrowsers
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject2Selenium/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add items to the ToDoApp - Firefox
	Given I navigate to LambdaTest App on the following environment
		| Browser | BrowserVersion     | OS    |
		| <Browser> | <BrowserVersion> |  <OS> |
	And I select the first item
	And I select the second item
	And I entr the new value in the textbox
	When I click the Submit button
	Then I verify whether the item is added to the list

	Examples:
		
		| Browser | BrowserVersion     | OS    |
		| firefox | 86.0 |  WIN10 |
