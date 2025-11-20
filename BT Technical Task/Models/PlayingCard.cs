namespace BT_Technical_Task.Models
{
    public class PlayingCard
    {
        //THINGS TO IMPROVE 
        // place magic numbers into variables 

        public string CardValue { get; set; }
        public string CardSuite { get; set; }
        public int ModifiedCardVal { get; set; }

        public PlayingCard(string cardVal, string cardSuite)
        {
            CardValue = cardVal;
            CardSuite = cardSuite;
            ModifiedCardVal = 0;
        }

        public static int JokerCount;
        public static bool isJokerAccepted()
        {
            JokerCount++;

            if (JokerCount >= 3)
                return false;
            else
                return true;
        }

        public static int CardValueModifier(PlayingCard card)
        {
            string rank = card.CardValue.ToLower();

            if (int.TryParse(rank, out int num))
            {
                card.ModifiedCardVal = num;
                return CardSuiteModifier(card);
            }

            card.ModifiedCardVal = rank switch
            {
                "t" => 10,
                "j" => 11,
                "q" => 12,
                "k" => 13,
                "a" => 14,
                _ => 0
            };

            return CardSuiteModifier(card);
        }

        public static int CardSuiteModifier(PlayingCard card)
        {
            int value = card.ModifiedCardVal; 

            return card.CardSuite.ToLower() switch
            {
                "c" => value * 1,
                "d" => value * 2,
                "h" => value * 3,
                "s" => value * 4,
                _ => value
            };
        }
    }
}
