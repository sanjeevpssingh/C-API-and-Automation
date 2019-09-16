Feature: SignInWithDifferentCredentials
	


Scenario Outline: SignIn With Different Credentials
	Given we are on Login page
	When Click on Sign In
	And User enter <email> and <password>
	When user Click on Sign In Button    
	Then An email address required should be visible
Examples:
| email                      | password |
|                            |          |
| sanjeevpssingh95@gmail.com |          |
|                            |  12345   |
| sanjeevpssingh95@gmail.com | abcde    |


	 