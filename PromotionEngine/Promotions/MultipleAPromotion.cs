using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PromotionEngine.SKUS;

namespace PromotionEngine.Promotions
{
    public class MultipleAPromotion : BasePromotion
    {
        private readonly int _amountForPromotion = 3;
        private readonly int _promotionPrice = 130;
        public override int CalculatePromotionPriceForCart(List<BaseSKU> cart)
        {
            var itemsOfType = cart.Where(sku => sku.GetType() == typeof(ASKU)).ToList();
            if (itemsOfType.Count == 0)
                return 0;
            var amountOfPromotions = itemsOfType.Count / _amountForPromotion; 
            var remainder = itemsOfType.Count % _amountForPromotion;
            return amountOfPromotions * _promotionPrice + (remainder * itemsOfType.FirstOrDefault().Price);
        }
    }
}
