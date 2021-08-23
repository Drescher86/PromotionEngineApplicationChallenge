using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PromotionEngine.SKUS;

namespace PromotionEngine.Promotions
{
    public class MixPromotion : BasePromotion
    {
        private readonly int _promotionalPrice = 30;
        public override int CalculatePromotionPriceForCart(List<BaseSKU> cart)
        {
            var cSkus = cart.Where(sku => sku.GetType() == typeof(CSKU)).ToList();
            var dSkus = cart.Where(sku => sku.GetType() == typeof(DSKU)).ToList();
            if(dSkus.Count > 0 && cSkus.Count > 0)
            {
                var diff = 0;
                var amountOfPromotions = dSkus.Count > cSkus.Count ? dSkus.Count : cSkus.Count;
                var diffPrice = 0;
                if(dSkus.Count > cSkus.Count)
                {
                    diff = dSkus.Count - cSkus.Count;
                    diffPrice = diff * dSkus.FirstOrDefault().Price;
                }
                else if(cSkus.Count > dSkus.Count)
                {
                    diff = cSkus.Count - dSkus.Count;
                    diffPrice = diff * cSkus.FirstOrDefault().Price;
                }
                return amountOfPromotions * _promotionalPrice + diffPrice;
            }
            else if(cSkus.Count > 0)
            {
                return cSkus.Count * cSkus.FirstOrDefault().Price;
            }
            else if(dSkus.Count > 0)
            {
                return dSkus.Count * dSkus.FirstOrDefault().Price;
            }
            return 0;
        }
    }
}
