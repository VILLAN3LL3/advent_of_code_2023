namespace Day_7
{
    public class Hand
    {
        public Hand(int bid, params char[] cards)
        {
            Bid = bid;
            Cards.AddRange(cards);
        }
        
        public List<char> Cards { get; set; } = [];
        public int Bid { get; set; }
    }
}