using BT_Technical_Task.Models;
using BT_Technical_Task.Services;

namespace PlayingCards.UnitTest
{
    public class PlayingCardsTests
    {
        [Fact]
        public void AcceptsListOfCards()
        {
            List<string> ListOfCardsTest = new List<string>() { "2C", "2D", "2H", "TC", "KC" };
            CardGame.StartGame(ListOfCardsTest);
            Assert.NotNull(CardGame.handOfCards);
        }

        [Fact]
        public void AddsSuiteModifier()
        {
            PlayingCard playingCard = new PlayingCard("2", "d");
            int ModifiedVal = PlayingCard.CardValueModifier(playingCard);
            Assert.Equal(4, ModifiedVal);
        }
        [Fact]
        public void AddsRankModifier()
        {
            PlayingCard playingCard = new PlayingCard("t", "d");
            int ModifiedVal = PlayingCard.CardValueModifier(playingCard);
            Assert.Equal(20, ModifiedVal);
        }

        [Theory]
        [InlineData(new string[] { "3C", "4C" }, 7)]
        [InlineData(new string[] { "TC", "TD", "TH", "TS" }, 100)]
        public void ListOfCardsScoreCorrectly(string[] cards, int expectedScore)
        {
            CardGame.StartGame(cards.ToList());
            Assert.Equal(expectedScore, CardGame.FinalGameScore);
        }

        [Fact]
        public void JokersInCardList()
        {

        }
        [Fact]
        public void CardToScoreConversion()
        {

        }

        [Fact]
        public void InvalidCardSelectionException()
        {


        }
    }
}
