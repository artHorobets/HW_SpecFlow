Feature: Search cars on site

As a user 
I want to have advanced search
in order to search cars with more parameters

As a user
I want to search passenger cars
in order to search only intesting to me auto

As a user
I want to search only new cars by price range
in order to search only new cars with the appropriate price for me

As a user
I want to know about actual promotions
in order to buy a car at a good price

Background: 
Given user on the AUTO.RIA homepage

Scenario: advanced search
  When user clicks on the button 'Розширений пошук'
  Then user reside at on the screen page with title 'Розширений пошук вживаних авто' 

Scenario: search passenger cars
  When user select "Автобуси" on tab 'транспорт'	
  And user clicks on element 'Пошук'
  Then user sees on the screen page with message 'Продаж Автобусів авто' 

Scenario: search only new cars by price range 10000-30000
  When user clicks on button_icon 'нові авто'	
  And user select "10000" on select_tab 'від'
  And user select "20000" on choose_tab 'до'
  Then user sees on the main_page text 'Нові авто в Україні' 

Scenario: promotional search cars
  When user cliks_on button_icon 'Новини'
  And user clicks on button_option 'Акції' 
  Then user sees title on choosen page 'На правах реклами' 
