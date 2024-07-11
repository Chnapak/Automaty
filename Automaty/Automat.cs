namespace Automaty
{
    internal class Automat
    {
        private string[] items = new string[3] { "sušenka", "bageta", "plechovka"};
        private int[] prices = new int[3] {20, 35, 40};
        

        public string GetMeRandom()
        {
            var rand = new Random();
            return items[rand.Next(items.Length)];
        }
        public int HowMuchCost(int index)
        {
            return prices[index];
        }
        public string GetMe(int index)
        {
            return items[0];
        }
    }
}
