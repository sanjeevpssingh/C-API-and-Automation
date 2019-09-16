Feature: SelectFlight


Scenario Outline: Select Flight
	Given I am on flight booking page
	And Click user clicks on Flight section
	When I select multi-select
	Then click on Add another flight
	Then Search for flights between different airports <FIRST>,<SECOND>,<THIRD> on dates <Date1>,<Date2>,<Date3>  for <number>  adults
	Then click on Search option
	And select First flight
	And compare the price
Examples:
| FIRST | SECOND | THIRD | Date1      | Date2      | Date3      | number |
| MLA   | LON    | ROM   | 02/17/2020 | 02/20/2020 | 02/24/2020 | 4      |





