namespace Shops
{
    public class NintendoWii : Product
    {
        public bool WiiWheel { get; private set; }

        public NintendoWii(string name, int price, string publisher, string genre, bool wiiwheel)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            Genre = genre;
            WiiWheel = wiiwheel;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }
    }
}