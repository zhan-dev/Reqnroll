Feature: Website Search Functionality

As an EPAM website user
I want to perform a search on the main page

@test1
Scenario Outline: Perform a search on the Epam website
    Given I navigate to the EPAM website
    When I click on the Search icon element
    And I enter the text '<text>' into the search input
    And I click on the Find button
    Then The list of search results is displayed on the page

    Examples:
    |text        |  
    |Automation  | 
    |Development |