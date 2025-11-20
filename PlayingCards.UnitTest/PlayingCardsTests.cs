using BT_Technical_Task.Models;
using BT_Technical_Task.Services;

namespace PlayingCards.UnitTest
{
    public class PlayingCardsTests
    {
        [Fact]
        public void AcceptsListOfCards()
        {
            CardGame game = new CardGame();

            List<string> ListOfCardsTest = new List<string>() { "2C", "2D", "2H", "TC", "KC" };
            game.StartGame(ListOfCardsTest);

            Assert.NotNull(game.Hand);
        }

        [Fact]
        public void AddsSuiteModifier()
        {
            var card = PlayingCard.Parse("2D");

            int score = card.GetScore();
            Assert.Equal(4, score);
        }
        [Fact]
        public void AddsRankModifier()
        {
            var card = PlayingCard.Parse("TD");

            int score = card.GetScore();
            Assert.Equal(20, score);
        }

        [Theory]
        [InlineData(new string[] { "3C", "4C" }, 7)]
        [InlineData(new string[] { "TC", "TD", "TH", "TS" }, 100)]
        public void ListOfCardsScoreCorrectly(string[] cards, int expectedScore)
        {
            CardGame game = new CardGame();
            int finalScore = game.StartGame(cards.ToList());
            Assert.Equal(expectedScore, finalScore);
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
