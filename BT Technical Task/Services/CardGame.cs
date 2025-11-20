using BT_Technical_Task.Models;

namespace BT_Technical_Task.Services
{
    public class CardGame
    {
        public static List<PlayingCard> handOfCards = new List<PlayingCard>();
        public static List<int> ModifiedCardValues = new List<int>();
        public static int FinalGameScore = 0;

        private static bool IsJokerModifierAccepted;


        public static void StartGame(List<string> ListOfCards)
        {
            //ensures previous game data is cleared
            handOfCards.Clear();
            ModifiedCardValues.Clear();
            FinalGameScore = 0;

            foreach (var card in ListOfCards)
            {
                string value = card.Substring(0, 1).ToLower();
                string suite = card.Substring(card.Length - 1, 1).ToLower();

                var playingCard = new PlayingCard(value, suite);

                // Convert and score
                int score = PlayingCard.CardValueModifier(playingCard);

                handOfCards.Add(playingCard);
                ModifiedCardValues.Add(score);

                FinalGameScore += score;
            }
        }
    }
}
