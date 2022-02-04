Feature: learn chess game

As a user 
I want to deside chess puzzle rush
in order to upgrade my skills

As a user
I want to search news about chess players
in order to learn the experience of other players

As a user
I want to play chess with computer
in order to training without partners

As a user
I want to search general chess discussion for reading
in order to keep up with the latest news from the world of chess

Background: 
Given user on the chess.com homepage

Scenario: deside chess puzzle rush
  When user clicks on button 'puzzle'	
  And user clicks on element_a 'puzzle rush'
  Then user watch messageon the screen page 'Puzzle Rush' 

  Scenario: search news about chess players
  When user input 'News' in search field 
  And user click on tab 'Today:News'
  And user select tab 'chess players'
  Then user sees menu with text 'Chess Players' 

  Scenario: play chess with computer
  When user cliks on button_p 'play'  
  And user select menu tab 'computer'
  And user click on tab_c 'Choose'
  And user click on tab_p 'Play'
  Then user sees bot message 'Thanks for playing chess with me. Good luck!' 

   Scenario: search general chess discussion for reading
  When user cliks on button_c 'Connect'  
  And user cliks on munu_d 'general chess discussion'
  Then user sees header title text 'General Chess Discussion' 