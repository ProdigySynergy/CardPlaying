# CardPlaying
A minimal card playing console application for shuffling and dealing cards
  - Card.cs - represents a card
  - Program.cs - runs the program
  - Deck.cs - Represents a deck of cards for playing an active game with 52 cards

## Init
Used to initialize a stack of cards
- 4 Suites
  - Spades
  - Hearts
  - Diamonds
  - Clubs
- 13 Faces for each Suite
  - Ace
  - 2
  - 3
  - 4
  - 5
  - 6
  - 7
  - 8
  - 9
  - 10
  - Jack
  - Queen
  - King

## Shuffle
Uses [Fisher-Yates](http://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle) algorithm to shuffle the deck of cards in place

## Rand
Generates a random number between min and max - 1

## DealCard
Pulls out a card from the top and deals it

## DealXCards
Pulls out x cards from the top and deal them

