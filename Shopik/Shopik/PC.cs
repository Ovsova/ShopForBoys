namespace Shops
{
    public class PCGames : Product
    {
        public string VideoCart { get; private set; }

        public PCGames(string name, int price, string publisher, string genre, string videoCart)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            Genre = genre;
            VideoCart = videoCart;

        }
    }
}