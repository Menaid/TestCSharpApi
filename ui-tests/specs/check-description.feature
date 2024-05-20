Feature: As a user I want to be able to see the description of the product when I choose a specific category

    Scenario: Check that the "Mat" -category shows the right products and "description".
        Given that I am on the product page
        When I choose the category "Prisvänligt"
        Then I should see the description "För studenten" for the product "Basic Tomatsås"
        And I should see the description "Om du vill ha ont i magen" for the product "Mjöliga makaroner"
        And I should see the description "Med en hint av kött" for the product "Dennis Korv"

    Scenario: Check that the "Mat"-category shows the right products and "description".
        Given that I am on the product page
        When I choose the category "Mat"
        Then I should see the description "Bra att steka karameliserad lök med" for the product "Gul lök"
        And I should see the description "Bra att göra mos på" for the product "Potatis"
        And I should see the description "Ebbas korv" for the product "Falukorv"

    Scenario: Check that the "Lyx"-category shows the right products and "description".
        Given that I am on the product page
        When I choose the category "Lyx"
        Then I should see the description "Om du vill stötta Putin" for the product "Rysk Caviar"
        And I should see the description "Från den ungerska rivieran" for the product "Champagne"
        And I should see the description "Har du tur så ser du på ett öga efteråt" for the product "Brännvin"

    Scenario: Check that the "Alla"-category shows the right products and "description".
        Given that I am on the product page
        When I choose the category "Alla"
        Then I should see the description "För studenten" for the product "Basic Tomatsås"
        And I should see the description "Om du vill ha ont i magen" for the product "Mjöliga makaroner"
        And I should see the description "Med en hint av kött" for the product "Dennis Korv"
        And I should see the description "Har du tur så ser du på ett öga efteråt" for the product "Brännvin"
        And I should see the description "Om du vill stötta Putin" for the product "Rysk Caviar"
        And I should see the description "Från den ungerska rivieran" for the product "Champagne"
        And I should see the description "Ebbas korv" for the product "Falukorv"
        And I should see the description "Bra att göra mos på" for the product "Potatis"
        And I should see the description "Bra att steka karameliserad lök med" for the product "Gul lök"