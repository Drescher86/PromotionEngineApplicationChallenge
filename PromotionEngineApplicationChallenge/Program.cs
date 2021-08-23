using PromotionEngine;
using System;

namespace PromotionEngineApplicationChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var promotion = new PromotionEngine.PromotionEngine();
            Console.WriteLine("Choose amount of A's:");
            var aAmountStr = Console.ReadLine();
            Console.WriteLine("Choose amount of B's:");
            var bAmountStr = Console.ReadLine();
            Console.WriteLine("Choose amount of C's:");
            var cAmountStr = Console.ReadLine();
            Console.WriteLine("Choose amount of D's:");
            var dAmountStr = Console.ReadLine();
            int.TryParse(aAmountStr, out int aAmount);
            int.TryParse(bAmountStr, out int bAmount);
            int.TryParse(cAmountStr, out int cAmount);
            int.TryParse(dAmountStr, out int dAmount);
            createSKUs("ASKU", aAmount, promotion);
            createSKUs("BSKU", bAmount, promotion);
            createSKUs("CSKU", cAmount, promotion);
            createSKUs("DSKU", dAmount, promotion);
            Console.WriteLine($"Total price is: {promotion.TotalPrice()}");
            Console.ReadLine();
        }

        private static void createSKUs(string skuName, int amount, PromotionEngine.PromotionEngine engine)
        {
            for(int i = 0; i < amount; i++)
            {
                engine.AddItemToCart(skuName);
            }
        }
    }
}
