using PromotionEngine.SKUS;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Promotions
{
    public class PromotionsCalculator : IPromotionsCalculator
    {
        private List<BasePromotion> _promotions;
        
        public PromotionsCalculator()
        {
            _promotions = new List<BasePromotion>
            {
                new MixPromotion(),
                new MultipleAPromotion(),
                new MultipleBPromotion()
            };
        }

        public int Calculate(List<BaseSKU> cart)
        {
            var total = 0;
            foreach(var promotion in _promotions)
            {
                total += promotion.CalculatePromotionPriceForCart(cart);
            }
            return total;
        }
    }
}
