namespace BT_Technical_Task.Models
{
    public class PlayingCard
    {
        public int CardValue { get; set; }
        public string CardSuite { get; set; }
        public int ModifiedCardVal { get; set; }

        public PlayingCard(int cardVal, string cardSuite)
        {
            CardValue = cardVal;
            CardSuite = cardSuite;
            ModifiedCardVal = cardVal;
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

        public static int CardSuiteModifier(PlayingCard card)
        {

            switch (card.CardSuite)
            {
                case "c":
                    card.ModifiedCardVal = card.CardValue * 1;
                    break;
                case "d":
                    card.ModifiedCardVal = card.CardValue * 2;
                    break;
                case "h":
                    card.ModifiedCardVal = card.CardValue * 3;
                    break;
                case "s":
                    card.ModifiedCardVal = card.CardValue * 4;
                    break;
                default:
                    Console.WriteLine($"Invalid Card Suite [{card.CardSuite}]");
                    card.ModifiedCardVal = card.CardValue;
                    break;
            }
            return card.ModifiedCardVal;
        }
        public static int CardValueModifier(PlayingCard card)
        {

            switch (card.CardSuite)
            {
                case "t":
                    card.ModifiedCardVal = card.CardValue  + 10;
                    break;
                case "j":
                    card.ModifiedCardVal = card.CardValue  + 12;
                    break;
                case "h":
                    card.ModifiedCardVal = card.CardValue + 13;
                    break;
                case "s":
                    card.ModifiedCardVal = card.CardValue + 14;
                    break;
                default:
                    Console.WriteLine($"Invalid Card Suite [{card.CardSuite}]");
                    card.ModifiedCardVal = card.CardValue;
                    break;
            }
            return card.ModifiedCardVal;
        }
    }
}
