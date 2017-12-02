using System;
namespace Shops
{
    public class XBOXGames : Product
    {
        public bool AvailabilityOfWebcam { get; private set; }

        public XBOXGames(string name, int price, string publisher, string genre, bool availabilityOfWebcam)
        {
            Name = name;
            Publisher = publisher;
            Price = price;
            Genre = genre;
            AvailabilityOfWebcam = availabilityOfWebcam;
        }
        public override double GetDiscountPrice(User user)
        {

            if (user.Date == 23 && AvailabilityOfWebcam == true)
            {
                return Price * 0.75;
            }
            if (user.Date == 8 && AvailabilityOfWebcam == false)
            {
                return Price * 0.85;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Игры на XBOX");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Издатель: " + Publisher);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Использование Web-камеры: " + AvailabilityOfWebcam);
            Console.WriteLine(new String('-', 25));
        }

    }
}