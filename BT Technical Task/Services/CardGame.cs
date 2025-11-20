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
        
        }
    }
}
