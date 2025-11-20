using BT_Technical_Task.Models;

namespace BT_Technical_Task.Services
{
    public class CardGame
    {
        public List<PlayingCard> Hand { get; private set; } = new();

        public static List<int> ModifiedCardValues = new List<int>();

        public static int FinalGameScore { get; private set; }

        private static bool IsJokerModifierAccepted;


        public static void StartGame(List<string> ListOfCards)
        {
            CardGame game = new CardGame();

            //ensures previous game data is cleared
            game.Hand.Clear();
            ModifiedCardValues.Clear();
            FinalGameScore = 0;

            foreach (var card in ListOfCards)
            {
                string value = card.Substring(0, 1).ToLower();
                string suite = card.Substring(card.Length - 1, 1).ToLower();

                var playingCard = new PlayingCard(value, suite);

                // Convert and score
                int score = PlayingCard.CardValueModifier(playingCard);

                game.Hand.Add(playingCard);
                ModifiedCardValues.Add(score);

                FinalGameScore += score;
            }
        }
    }
}
