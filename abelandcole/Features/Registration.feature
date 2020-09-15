Feature: Registration
	As a user
	In order to be able to use Abel&Cole Website
	The user must register 

@mytag
Scenario Outline: Valid Registration
	Given the user navigate to "https://www.abelandcole.co.uk/"
	And the user click signup
	And the user accept the cookies
	And the user select the Title
	And the user enter the firstname"<fname>"
	And the user send the lastname "<lname>"
	And the user enter email address "<email>"
	And the user enter a valid password "<pass>"
	And the user enter the postcode"<pcode>"
	And the user click find address
	And the user select address from the dropdown
	And the user enter description of where to keep order"<discptn>"
	And the user enter contact number"<contactNo>"
	And the user select where he heard about the company 
	And the user to tick he/she is a vegetarian
	And the user to tick the box if he/she is a vegan
	And the user to tick yes or No if he or she likes to recieve regulary email from company 
	When the user click signUp button
	#Then the user should be succesffully registered

Examples: 

| fname    | lname    | email              | pass              | pcode   | discptn                                           | contactNo  |
| Yinka    | Owo      | service2@yahoo.com | timewaitfornoman1 | B20 3AR | kindly drop the order at the back on the bin      | 08065025974 |
#| Pelu     | Emiola   | service2@yahoo.com | timewaitfornoman2 | B20 3AR | kindly drop the order in the bin                  | 0806502598 |
#| Sunkanmi | Damilola | service3@yahoo.com | timewaitfornoman3 | B20 3AR | kindly drop the order at the back of the car park | 0806502599 |

	