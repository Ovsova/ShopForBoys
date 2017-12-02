using System;
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
        public override void GetWrite()
        {
            Console.WriteLine("Игра на PC");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Издеатель: " + Publisher);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Видеокарта: " + VideoCart+ "и выше");
            Console.WriteLine(new String('-', 25));
        }

        public override double GetDiscountPrice(User user)
        {

            if (user.Date == 23)
            {
                return Price * 0.75;
            }
            if (user.Date == 23 && Price > 1500)
            {
                return Price * 0.85;
            }
            return Price;
        }
    }
}