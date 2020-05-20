﻿using BootCamp.Chapter.Gambling;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class Tests
    {
        //TODO Add test for DrawRandom
        /*
         * all public methodes.
            Card DrawFromTop();
            Card DrawRandom();
            Card DrawAt(int index);
            void Shuffle();
         */
        private static List<Card> FullDeckOfCards()
        {
            List<Card> cardsDeck = new List<Card>();
            foreach (Card.Suites suite in (Card.Suites[])Enum.GetValues(typeof(Card.Suites)))
            {
                foreach (Card.Ranks rank in (Card.Ranks[])Enum.GetValues(typeof(Card.Ranks)))
                {
                    cardsDeck.Add(new Card(suite, rank));
                }
            }
            return cardsDeck;
        }

        [Fact]
        public void When_No_Cards_Given_To_Deck_Should_Throw_ArgumentNullException()
        {
            List<Card> cards = null;

            Action action = () => new Deck(cards);

            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Draw_When_Deck_Has_No_Cards_Should_Throw_OutOfCardsException()
        {
            IDeck deck = new Deck(new List<Card>());

            Action action = () => deck.DrawFromTop();

            action.Should().Throw<OutOfCardsException>();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(100)]
        public void DrawAt_Out_Of_Index_Should_Throw_Out_Of_Range(int index)
        {
            //Arrange
            List<Card> cards = FullDeckOfCards();
            IDeck deck = new Deck(cards);

            //Act
            Action action = () => deck.DrawAt(index);

            //Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void DrawAt_Index_Within_Range_should_Give_Correct_Card()
        {
            //Arrange
            List<Card> cards = FullDeckOfCards();
            IDeck deck = new Deck(cards);

            //Act
            Card pickedCard = deck.DrawAt(1);

            //Assert wich is better and why?
            Assert.Equal(cards[1], pickedCard);
            //pickedCard.Should().Be(cards[index]);
        }


        [Fact]
        public void DrawFromTop_Should_Give_Last_Card_In_List()
        {
            //Arrange
            Card lastCard = new Card(Card.Suites.Hearts, Card.Ranks.Ace);
            List<Card> cards = FullDeckOfCards();
            cards.Add(lastCard);
            IDeck deck = new Deck(cards);

            //Act
            Card cardDrawn = deck.DrawFromTop();

            //Assert
            cardDrawn.Should().Be(lastCard);
        }
        [Fact]
        public void Shuffle_Should_Return_Different_Order()
        {
            //Arrange
            List<Card> cards = FullDeckOfCards();
            IDeck deck = new Deck(FullDeckOfCards());

            //Act
            deck.Shuffle();
            List<Card> shuffledDeck = new List<Card>();
            for (int i = 0; i < cards.Count; i++)
            {
                shuffledDeck.Add(deck.DrawFromTop());
            }
            shuffledDeck.Reverse();

            //Assert
            Assert.NotEqual(shuffledDeck, cards);
        }
    }
}
