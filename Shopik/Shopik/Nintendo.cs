using System;
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
        public override void GetWrite()
        {
            Console.WriteLine("Игра на NintendoWii");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Издеатель: " + Publisher);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Наличие Wii Wheel: " + WiiWheel);
            Console.WriteLine(new String('-', 25));
        }
        public override double GetDiscountPrice(User user)
        {
            if (user.Date == 23 && WiiWheel == false)
            {
                return Price * 0.6;
            }
            return Price;
        }
    }
}