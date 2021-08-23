using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.SKUS
{
    public abstract class BaseSKU
    {
        public int Price { get; private set; }

        public BaseSKU(int price)
        {
            Price = price;
        }
    }
}
