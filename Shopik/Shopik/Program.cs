using System;
using System.Collections.Generic;

namespace Shops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User user = new User(
                "Grace",
                "Calle de Alcal ",
                5000,
                1500
            );
            Console.WriteLine("Список товаров:");

            PSGames LastOfUs = new PSGames(
                "Last of Us",
                1600,
                "Sony Computer Entertainment",
                "Action - adventure",
                false
            );
            Console.WriteLine("Игра на PC");
            Console.WriteLine("Название: " + LastOfUs.Name);
            Console.WriteLine("Цена: " + LastOfUs.Price);
            Console.WriteLine("Издеатель: " + LastOfUs.Publisher);
            Console.WriteLine("Жанр: " + LastOfUs.Genre);
            Console.WriteLine("Наличие VR: " + LastOfUs.VR);
            Console.WriteLine(new String('-', 25));

            XBOXGames JustDance4 = new XBOXGames(
                "JustDance 4",
                1800,
                "Ubisoft",
                "музыкальная игра",
                true
            );
            Console.WriteLine("Игры на XBOX");
            Console.WriteLine("Название: " + JustDance4.Name);
            Console.WriteLine("Цена: " + JustDance4.Price);
            Console.WriteLine("Издатель: " + JustDance4.Publisher);
            Console.WriteLine("Жанр: " + JustDance4.Genre);
            Console.WriteLine("Использование Web-камеры: " + JustDance4.AvailabilityOfWebcam);
            Console.WriteLine(new String('-', 25));

            PCGames Destiny2 = new PCGames(
                "Destiny 2",
                2000,
                "Activision",
                "MMOFPS",
                "GTX 970 4GB"
            );
            Console.WriteLine("Игры на PS");
            Console.WriteLine("Название: " + Destiny2.Name);
            Console.WriteLine("Цена: " + Destiny2.Price);
            Console.WriteLine("Издатель: " + Destiny2.Publisher);
            Console.WriteLine("Жанр: " + Destiny2.Genre);
            Console.WriteLine("Видеокарта: " + Destiny2.Genre + "и выше");
            Console.WriteLine(new String('-', 25));

            PSVita CallOfDuty = new PSVita(
               "CallOfDuty:BlackOpsDeclassified",
               1500,
               "Шутер от первого лица",
               "Sony Computer Entertainment",
               true
           );
            Console.WriteLine("Игра на PS Vita");
            Console.WriteLine("Название: " + CallOfDuty.Name);
            Console.WriteLine("Цена: " + CallOfDuty.Price);
            Console.WriteLine("Издеатель: " + CallOfDuty.Publisher);
            Console.WriteLine("Жанр: " + CallOfDuty.Genre);
            Console.WriteLine("Наличие AR card: " + CallOfDuty.ARcard);
            Console.WriteLine(new String('-', 25));

            NintendoWii Mario = new NintendoWii(
               "MarioKart",
               2530,
               "Nintendo Entertainment Analysis and Development",
               "Автосимулятор",
               true
           );
            Console.WriteLine("Игра на NintendoWii");
            Console.WriteLine("Название: " + Mario.Name);
            Console.WriteLine("Цена: " + Mario.Price);
            Console.WriteLine("Издеатель: " + Mario.Publisher);
            Console.WriteLine("Жанр: " + Mario.Genre);
            Console.WriteLine("Наличие Wii Wheel: " + Mario.WiiWheel);
            Console.WriteLine(new String('-', 25));

            Product[] products = new Product[]
            {
                LastOfUs, JustDance4, Destiny2, CallOfDuty, Mario 
            };

            PSGames[] psGames = new PSGames[]
            {
                LastOfUs
            };


            Informer informer = new Informer();
            ///как надо делать маркетинг!!!!
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуй {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);
                if (productNumber >= 0 && productNumber < products.Length)
                {
                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }
                else
                {
                    Console.WriteLine("Такого товара нет");
                }
            }
        }
    }
}