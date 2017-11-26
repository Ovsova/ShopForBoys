namespace Shops
{
    public class PSGames : Product
    {
        public bool VR{ get; private set; }

        public PSGames(string name, int price, string publisher, string genre, bool vr)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            Genre = genre;
            VR = vr;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }
    }
}