using System;
namespace Shops
{
    public class PSGames : Product
    {
        public bool VR { get; private set; }

        public PSGames(string name, int price, string publisher, string genre, bool vr)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            Genre = genre;
            VR = vr;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Игра на PC");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Издеатель: " + Publisher);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Наличие VR: " + VR);
            Console.WriteLine(new String('-', 25));
        }
        public override double GetDiscountPrice(User user)
        {
            if (user.DayOfTheWeek == "Friday")
            {
                return Price * 0.5;
            }
            return Price;
        }
    }
}
