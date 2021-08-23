using PromotionEngine.IOC;
using PromotionEngine.Promotions;
using PromotionEngine.SKUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PromotionEngine
{
    public class PromotionEngine
    {
        private List<BaseSKU> _cart;
        private IOCContainer _ioc;

        public PromotionEngine()
        {
            _cart = new List<BaseSKU>();
            _ioc = new IOCContainer();
        }

        public void AddItemToCart(string SKU)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(typ => typ.IsClass && typ.Namespace == "PromotionEngine.SKUS");
            var type = types.FirstOrDefault(typ => typ.Name == SKU);
            var sku = Activator.CreateInstance(type) as BaseSKU;
            if(sku != null)
            {
                _cart.Add(sku);
            }
        }

        public int TotalPrice()
        {
            return _ioc.Resolve<IPromotionsCalculator>().Calculate(_cart);
        }
    }
}
