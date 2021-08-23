using PromotionEngine.SKUS;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Promotions
{
    public abstract class BasePromotion
    {
        public abstract int CalculatePromotionPriceForCart(List<BaseSKU> cart);
    }
}
