using BT_Technical_Task.Models;
namespace PlayingCards.UnitTest
{
    public class PlayingCardsTests
    {
        [Fact]
        public void AcceptsListOfCards()
        {

        }

        [Fact]
        public void AddsSuiteModifier()
        {
            PlayingCard playingCard = new PlayingCard(2, "d");
            int ModifiedVal = PlayingCard.CardSuiteModifier(playingCard);
            Assert.Equal(4, ModifiedVal);
        }
        [Fact]
        public void AddsRankModifier()
        {
   
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
