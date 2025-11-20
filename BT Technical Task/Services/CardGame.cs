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

            int baseScore = 0;
            int jokerCount = 0;

            HashSet<string> seenNonJokers = new();

            foreach (var cardStr in ListOfCards)
            {
                var card = PlayingCard.Parse(cardStr);
                game.Hand.Add(card);
                Score += card.GetScore();

                if (card.IsJoker)
                {
                    jokerCount++;
                    if (jokerCount > 2)
                        throw new InvalidOperationException("A Joker (JR) can only appear twice.");
                }
                else
                {
                    if (!seenNonJokers.Add(cardStr.ToLower()))
                        throw new InvalidOperationException($"Duplicate card detected: {cardStr}");

                    baseScore += card.GetScore();
                }
            }
            int multiplier = (int)Math.Pow(2, jokerCount);
            Score = baseScore * multiplier;

            return Score;

        }
    }
}
