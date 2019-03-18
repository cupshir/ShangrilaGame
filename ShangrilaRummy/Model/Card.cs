namespace ShangrilaRummy.Model
{
    public class Card
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
        public int DealValue { get; set; }

        public Card()
        {
        }
    }
}
