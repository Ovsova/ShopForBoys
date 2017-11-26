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

            // Писишные игры
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

            PSGames Fallout = new PSGames(
                "Fallout 4 VR",
                2000,
                "Bethesda Game Studios",
                "RPG",
                true
            );
            Console.WriteLine("Игра на PC");
            Console.WriteLine("Название: " + Fallout.Name);
            Console.WriteLine("Цена: " + Fallout.Price);
            Console.WriteLine("Издеатель: " + Fallout.Publisher);
            Console.WriteLine("Жанр: " + Fallout.Genre);
            Console.WriteLine("Наличие VR: " + Fallout.VR);
            Console.WriteLine(new String('-', 25));

            PSGames Uncharted = new PSGames(
              "Uncharted 4",
              3000,
              "Naughty Dog",
              "Action - adventure",
              false
          );
            Console.WriteLine("Игра на PC");
            Console.WriteLine("Название: " + Uncharted.Name);
            Console.WriteLine("Цена: " + Uncharted.Price);
            Console.WriteLine("Издеатель: " + Uncharted.Publisher);
            Console.WriteLine("Жанр: " + Uncharted.Genre);
            Console.WriteLine("Наличие VR: " + Uncharted.VR);
            Console.WriteLine(new String('-', 25));

            //иксбоксовские игры
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

            XBOXGames Halo = new XBOXGames(
              "Halo 5",
              2800,
              "343 Industries",
              "Шутер от первого лица",
              false
          );
            Console.WriteLine("Игры на XBOX");
            Console.WriteLine("Название: " + Halo.Name);
            Console.WriteLine("Цена: " + Halo.Price);
            Console.WriteLine("Издатель: " + Halo.Publisher);
            Console.WriteLine("Жанр: " + Halo.Genre);
            Console.WriteLine("Использование Web-камеры: " + Halo.AvailabilityOfWebcam);
            Console.WriteLine(new String('-', 25));

            XBOXGames SunsetOverdrive = new XBOXGames(
             "SunsetOverdrive",
             2200,
             "Insomniac Games",
             "Шутер от третьего лица",
             false
         );
            Console.WriteLine("Игры на XBOX");
            Console.WriteLine("Название: " + Halo.Name);
            Console.WriteLine("Цена: " + Halo.Price);
            Console.WriteLine("Издатель: " + Halo.Publisher);
            Console.WriteLine("Жанр: " + Halo.Genre);
            Console.WriteLine("Использование Web-камеры: " + Halo.AvailabilityOfWebcam);
            Console.WriteLine(new String('-', 25));

            //пекашные игры
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

            PCGames Witcher = new PCGames(
                "Witcher 3",
                1500,
                "CD Projekt RED",
                "Action/RPG",
                "GTX 770"
            );
            Console.WriteLine("Игры на PS");
            Console.WriteLine("Название: " + Witcher.Name);
            Console.WriteLine("Цена: " + Witcher.Price);
            Console.WriteLine("Издатель: " + Witcher.Publisher);
            Console.WriteLine("Жанр: " + Witcher.Genre);
            Console.WriteLine("Видеокарта: " + Witcher.Genre + "и выше");
            Console.WriteLine(new String('-', 25));

            PCGames PUBG= new PCGames(
                "PlayerUnknown's Battlegrounds",
                900,
                "Bluehole",
                "Королевская битва",
                "GTX 660 2GB"
            );
            Console.WriteLine("Игры на PS");
            Console.WriteLine("Название: " + PUBG.Name);
            Console.WriteLine("Цена: " + PUBG.Price);
            Console.WriteLine("Издатель: " + PUBG.Publisher);
            Console.WriteLine("Жанр: " + PUBG.Genre);
            Console.WriteLine("Видеокарта: " + PUBG.Genre + "и выше");
            Console.WriteLine(new String('-', 25));

            //витовские игры
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

            PSVita TTT = new PSVita(
               "Table TOP Tanks",
               70,
               "Боевик",
               "SCEE",
               true
           );
            Console.WriteLine("Игра на PS Vita");
            Console.WriteLine("Название: " + TTT.Name);
            Console.WriteLine("Цена: " + TTT.Price);
            Console.WriteLine("Издеатель: " + TTT.Publisher);
            Console.WriteLine("Жанр: " + TTT.Genre);
            Console.WriteLine("Наличие AR card: " + TTT.ARcard);
            Console.WriteLine(new String('-', 25));

            PSVita Batman = new PSVita(
              "LEGO: Batman 3",
              1300,
              "Action - adventure",
              "Warner Bros. Interactive Entertainment",
              false
          );
            Console.WriteLine("Игра на PS Vita");
            Console.WriteLine("Название: " + Batman.Name);
            Console.WriteLine("Цена: " + Batman.Price);
            Console.WriteLine("Издеатель: " + Batman.Publisher);
            Console.WriteLine("Жанр: " + Batman.Genre);
            Console.WriteLine("Наличие AR card: " + Batman.ARcard);
            Console.WriteLine(new String('-', 25));

            //виивские игры
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


            NintendoWii Resident = new NintendoWii(
               "Resident Evil 4: Wii Edition",
               1500,
               "Capcom Production Studio 4",
               "Боевик от третьего лица/Survival horror",
               false
           );
            Console.WriteLine("Игра на NintendoWii");
            Console.WriteLine("Название: " + Resident.Name);
            Console.WriteLine("Цена: " + Resident.Price);
            Console.WriteLine("Издеатель: " + Resident.Publisher);
            Console.WriteLine("Жанр: " + Resident.Genre);
            Console.WriteLine("Наличие Wii Wheel: " + Resident.WiiWheel);
            Console.WriteLine(new String('-', 25));

            NintendoWii Naruto = new NintendoWii(
               "Naruto Shippuden: Gekitou Ninja Taisen Special",
               1300,
               "Takara Tomy",
               "Fighting",
               false
           );
            Console.WriteLine("Игра на NintendoWii");
            Console.WriteLine("Название: " + Naruto.Name);
            Console.WriteLine("Цена: " + Naruto.Price);
            Console.WriteLine("Издеатель: " + Naruto.Publisher);
            Console.WriteLine("Жанр: " + Naruto.Genre);
            Console.WriteLine("Наличие Wii Wheel: " + Naruto.WiiWheel);
            Console.WriteLine(new String('-', 25));



            Product[] products = new Product[]
            {
                LastOfUs, JustDance4, Destiny2, CallOfDuty, Mario, Witcher, SunsetOverdrive, Naruto, Resident, TTT, Batman, Halo, PUBG, Uncharted, Fallout
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