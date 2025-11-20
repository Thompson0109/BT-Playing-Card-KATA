using BT_Technical_Task.Models;

namespace BT_Technical_Task.Services
{
    public class CardGame
    {
        public List<PlayingCard> Hand { get; private set; } = new();

        public static List<int> ModifiedCardValues = new List<int>();

        public int Score { get; private set; }

        private static bool IsJokerModifierAccepted;


        public  int StartGame(List<string> ListOfCards)
        {
            CardGame game = new CardGame();

            //ensures previous game data is cleared
            game.Hand.Clear();
            ModifiedCardValues.Clear();
            Score = 0;

            foreach (var cardText in ListOfCards)
            {
                var card = PlayingCard.Parse(cardText);
                game.Hand.Add(card);
                Score += card.GetScore();
            }
            return Score;

        }
    }
}
