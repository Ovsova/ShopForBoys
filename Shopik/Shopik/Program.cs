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
                1500,
                23,
                "Friday"
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
           

            PSGames Fallout = new PSGames(
                "Fallout 4 VR",
                2000,
                "Bethesda Game Studios",
                "RPG",
                true
            );
          

            PSGames Uncharted = new PSGames(
              "Uncharted 4",
              3000,
              "Naughty Dog",
              "Action - adventure",
              false
          );

            LastOfUs.GetWrite();
            Fallout.GetWrite();
            Uncharted.GetWrite();

            //иксбоксовские игры
            XBOXGames JustDance4 = new XBOXGames(
                "JustDance 4",
                1800,
                "Ubisoft",
                "музыкальная игра",
                true
            );
            

            XBOXGames Halo = new XBOXGames(
              "Halo 5",
              2800,
              "343 Industries",
              "Шутер от первого лица",
              false
          );
          

            XBOXGames SunsetOverdrive = new XBOXGames(
             "SunsetOverdrive",
             2200,
             "Insomniac Games",
             "Шутер от третьего лица",
             false
         );
            JustDance4.GetWrite();
            Halo.GetWrite();
            SunsetOverdrive.GetWrite();

            //пекашные игры
            PCGames Destiny2 = new PCGames(
                "Destiny 2",
                2000,
                "Activision",
                "MMOFPS",
                "GTX 970 4GB"
            );
        

            PCGames Witcher = new PCGames(
                "Witcher 3",
                1500,
                "CD Projekt RED",
                "Action/RPG",
                "GTX 770"
            );
           

            PCGames PUBG= new PCGames(
                "PlayerUnknown's Battlegrounds",
                900,
                "Bluehole",
                "Королевская битва",
                "GTX 660 2GB"
            );

            Destiny2.GetWrite();
            Witcher.GetWrite();
            PUBG.GetWrite();

            //витовские игры
            PSVita CallOfDuty = new PSVita(
               "CallOfDuty:BlackOpsDeclassified",
               1500,
               "Шутер от первого лица",
               "Sony Computer Entertainment",
               true
           );

           

            PSVita TTT = new PSVita(
               "Table TOP Tanks",
               70,
               "Боевик",
               "SCEE",
               true
           );
           

            PSVita Batman = new PSVita(
              "LEGO: Batman 3",
              1300,
              "Action - adventure",
              "Warner Bros. Interactive Entertainment",
              false
          );

            CallOfDuty.GetWrite();
            TTT.GetWrite();
            Batman.GetWrite();

            //виивские игры
            NintendoWii Mario = new NintendoWii(
               "MarioKart",
               2530,
               "Nintendo Entertainment Analysis and Development",
               "Автосимулятор",
               true
           );
            

            NintendoWii Resident = new NintendoWii(
               "Resident Evil 4: Wii Edition",
               1500,
               "Capcom Production Studio 4",
               "Боевик от третьего лица/Survival horror",
               false
           );
            

            NintendoWii Naruto = new NintendoWii(
               "Naruto Shippuden: Gekitou Ninja Taisen Special",
               1300,
               "Takara Tomy",
               "Fighting",
               false
           );

            Mario.GetWrite();
            Resident.GetWrite();
            Naruto.GetWrite();



            Product[] products = new Product[]
            {
                LastOfUs, JustDance4, Destiny2, CallOfDuty, Mario, Witcher, SunsetOverdrive, Naruto, Resident, TTT, Batman, Halo, PUBG, Uncharted, Fallout
            };


            Informer informer = new Informer();
         
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