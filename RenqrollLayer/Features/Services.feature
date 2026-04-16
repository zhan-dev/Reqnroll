Feature: Services Page Functionality

As an EPAM website user
I want to cover Services Page Functionality

@servicesTitleValidation
Scenario: Validate Services title
    Given I navigate to the EPAM website
    When I click on the Services navigation link
    Then The page title is 'Services | EPAM'

@servicesDropDownMenuValidation
Scenario Outline: Validate Navigation to Services Section
    Given I navigate to the EPAM website
    When I click on the Services navigation link
    And I took away cursor from the Services navigation link
    And I hover cursor on the Services navigation link
    And I click to '<category>' from Services dropdown menu
    Then The page title is '<expectedTitle>'
    And The section 'Our Related Expertise' is displayed on the page

    Examples:
    | category       | expectedTitle                                |
    | Generative AI  | Generative AI \| EPAM                        |
    | Responsible AI | Responsible AI Assessment & Services \| EPAM |