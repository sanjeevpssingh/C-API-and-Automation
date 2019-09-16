Feature:restFeature

Scenario Outline: Register a new User with Valid Username and EmailId
When I register a new User with '<usernameState>' Username and '<passwordState>' Password
Then registration is successful
And token is generated

Examples:
| usernameState             | passwordState |
|eve.holt@reqres.in         | pistol        |

Scenario Outline:Register a New User with Invalid combinations
When I register again new User with '<usernameState>' Username and '<passwordState>' Password
Then registration is not successful 

Examples:
| usernameState        | passwordState |
| abcdef               |   qwerty       |
| abcd@1234.com        |  sanju        |
| eve.holt@reqres.in   |               |

Scenario: List of all users
When user sends a request on users
Then user will get list of users
