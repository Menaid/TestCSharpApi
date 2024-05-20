Feature: As a user I want to be able to see the price of the product when I choose a specific category

    Scenario: Check that the "Mat" -category shows the right products and "price".
        Given that I am on the product page
        When I choose the category "Prisvänligt"
        Then I should see the price "10" for the product "Basic Tomatsås"
        And I should see the price "25" for the product "Mjöliga makaroner"
        And I should see the price "15" for the product "Dennis Korv"

    Scenario: Check that the "Mat"-category shows the right products and "price".
        Given that I am on the product page
        When I choose the category "Mat"
        Then I should see the price "35" for the product "Gul lök"
        And I should see the price "25" for the product "Potatis"
        And I should see the price "35" for the product "Falukorv"

    Scenario: Check that the "Lyx"-category shows the right products and "price".
        Given that I am on the product page
        When I choose the category "Lyx"
        Then I should see the price "90" for the product "Rysk Caviar"
        And I should see the price "75" for the product "Champagne"
        And I should see the price "150" for the product "Brännvin"

    Scenario: Check that the "Alla"-category shows the right products and "price".
        Given that I am on the product page
        When I choose the category "Alla"
        Then I should see the description "10" for the product "Basic Tomatsås"
        And I should see the description "25" for the product "Mjöliga makaroner"
        And I should see the description "15" for the product "Dennis Korv"
        And I should see the description "150" for the product "Brännvin"
        And I should see the description "90" for the product "Rysk Caviar"
        And I should see the description "75" for the product "Champagne"
        And I should see the description "35" for the product "Falukorv"
        And I should see the description "25" for the product "Potatis"
        And I should see the description "35" for the product "Gul lök"