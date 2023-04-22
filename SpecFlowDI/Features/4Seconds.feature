Feature: 4Seconds

@4secs
Scenario: Demostrate parallel running 40 seconds (with context dependency injection using BoDi) 
    Given I start the 4 second demo
    When I wait for 2 seconds 
    And I wait for 2 seconds  
    Then finish and demostrate context independence