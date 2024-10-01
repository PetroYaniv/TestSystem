Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](TestWep/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: LoginUser
	Given userLogin is locked_out_user
	And userPassword is secret_sauce
	Then I open website
	When The two Inputs are input
	And The button was pressed
	Then result should be Epic sadface: Sorry, this user has been locked out.