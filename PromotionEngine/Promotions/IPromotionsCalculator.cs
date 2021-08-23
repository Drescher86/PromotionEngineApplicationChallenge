using PromotionEngine.SKUS;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Promotions
{
    public interface IPromotionsCalculator
    {
        abstract int Calculate(List<BaseSKU> cart);
    }
}
