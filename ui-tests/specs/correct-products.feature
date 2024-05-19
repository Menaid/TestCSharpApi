Feature: As user I want to be able to see the correct products listed when I have chosen a category so that I can easily filter the product list by category.

  Scenario: Check that the "Prisvänligt"-category shows the right products.
    Given that I am on the product page
    When I choose the category "Prisvänligt"
    Then I should see the product "Basic tomatsås"
    And I should see the product "Mjöliga makaroner"
    And I should see the product "Dennis Korv"

  Scenario: Check that the "Lyx"-category shows the right products.
    Given that I am on the product page
    When I choose the category "Lyx"
    Then I should see the product "Brännvin"
    And I should see the product "Champagne"
    And I should see the product "Rysk Caviar"

  Scenario: Check that the "Mat"-category shows the right products.
    Given that I am on the product page
    When I choose the category "Mat"
    Then I should see the product "Basic tomatsås"
    And I should see the product "Mjöliga makaroner"
    And I should see the product "Dennis Korv"

  Scenario: Check that the "Alla"-category shows the right products.
    Given that I am on the product page
    When I choose the category "Alla"
    Then I should see the product "Basic tomatsås"
    And I should see the product "Mjöliga makaroner"
    And I should see the product "Dennis Korv"
    And I should see the product "Brännvin"
    And I should see the product "Rysk Kaviar"
    And I should see the product "Champagne"
    And I should see the product "Falukorn"
    And I should see the product "Potatis"
    And I should see the product "Gul lök"