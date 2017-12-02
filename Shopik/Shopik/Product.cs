using System;
namespace Shops
{
    public class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }

        public virtual void GetWrite()
        {
            Console.WriteLine("Игры");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Издательство: " + Publisher);
            Console.WriteLine("Жанр: " + Genre);
        }
        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }

            if (user.Spent < 1000)
            {
                return Price * 0.2;
            }
            return Price * 0.1;
        }
    }
}