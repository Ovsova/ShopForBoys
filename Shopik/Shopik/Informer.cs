﻿using System;

namespace Shops
{
    public class Informer
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купила {product.Name} за {price}. Заказ отправлен на склад");
        }
    }
}