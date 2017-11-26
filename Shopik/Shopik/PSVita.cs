namespace Shops
{
    public class PSVita : Product
    {
        public bool ARcard { get; private set; }

        public PSVita(string name, int price, string publisher, string genre, bool arcard)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            Genre = genre;
            ARcard = arcard;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }
    }
}