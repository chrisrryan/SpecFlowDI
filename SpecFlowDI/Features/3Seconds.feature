Feature: 3Seconds

@3secs
Scenario: Demostrate parallel running 60 seconds (with context dependency injection using BoDi) 
    Given I start the 3 second demo
    When I wait for 2 seconds 
    And I wait for 1 seconds  
    Then finish and demostrate context independence