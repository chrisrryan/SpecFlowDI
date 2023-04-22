Feature: 2Seconds

@2secs
Scenario: Demostrate parallel running 20 seconds (with context dependency injection using BoDi) 
    Given I start the 2 second demo
    When I wait for 1 seconds 
    And I wait for 1 seconds  
    Then finish and demostrate context independence