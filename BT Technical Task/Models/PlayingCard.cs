namespace BT_Technical_Task.Models
{
    public class PlayingCard
    {
        //THINGS TO IMPROVE 
        // place magic numbers into variables 

        public int Rank { get; }
        public int SuitMultiplier { get; }
        public string RawValue { get; }
        public string RawSuit { get; }

        public PlayingCard(int rank, int suitMultiplier, string rawValue, string rawSuit)
        {
            Rank = rank;
            SuitMultiplier = suitMultiplier;
            RawValue = rawValue;
            RawSuit = rawSuit;
        }


        public static PlayingCard Parse(string text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length < 2)
                throw new ArgumentException($"Invalid card format: {text}");

            string rawRank = text[..^1].ToLower();      // everything except last char
            string rawSuit = text[^1..].ToLower();      // last char

            int rank = MapRank(rawRank);
            int suitMul = MapSuit(rawSuit);

            return new PlayingCard(rank, suitMul, rawRank, rawSuit);
        }

        private static int MapRank(string rank)
        {
            if (int.TryParse(rank, out int num)) return num;

            return rank switch
            {
                "t" => 10,
                "j" => 11,
                "q" => 12,
                "k" => 13,
                "a" => 14,
                _ => throw new ArgumentException($"Invalid card rank: {rank}")
            };
        }


        private static int MapSuit(string suit)
        {
            return suit switch
            {
                "c" => 1,
                "d" => 2,
                "h" => 3,
                "s" => 4,
                _ => throw new ArgumentException($"Invalid card suit: {suit}")
            };
        }


        public int GetScore() => Rank * SuitMultiplier;
    }
}

