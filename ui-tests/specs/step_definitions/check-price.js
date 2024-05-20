import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

// Given('that I am on the product page', () => {
//     cy.visit('/products');
// });

// When('I choose the category {string}', (category) => {
//     cy.get('#categories').select(category);
// });

Then('I should see the price {string} for the product {string}', (price, productName) => {
    cy.get('.product').contains('div.product', productName).find('.price').contains('Pris: ' + price + ' kr')
});