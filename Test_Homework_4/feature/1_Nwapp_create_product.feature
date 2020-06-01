Feature:  Nwapp create
   As a user 
   I want to open the nwapp
   So I can create new product

Scenario: Create new product for nwapp

   Given I am at the login page
   When I type in fields username and password
   And I click the login button
   And I click the allproducts text
   And I open createNew page
   And I create the new product
   Then I have to make sure that the new product is on the allProducts page

