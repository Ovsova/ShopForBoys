using System;
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
            if (Price > 1000)
            {
                return Price / 2;
            }
                return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Игра на PS Vita");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Издеатель: " + Publisher);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Наличие AR card: " + ARcard);
            Console.WriteLine(new String('-', 25));
        }
        
    }
}