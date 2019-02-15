Feature: Sign In functionality
  As a customer
  In order to use the application
  I want to login with an email and password

@Signin
Scenario: Sign In with valid credentials
 Given I am at the My Account page
  When I fill the account email textbox with my email
   And I fill the password textbox with my password
   And I click the Sign In button
  Then I should be at the My account page