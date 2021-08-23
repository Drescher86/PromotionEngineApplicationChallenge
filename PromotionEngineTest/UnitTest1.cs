using NUnit.Framework;
using PromotionEngine;

namespace PromotionEngineTest
{
    public class Tests
    {
        private PromotionEngine.PromotionEngine _promotionEngine;
        [SetUp]
        public void Setup()
        {
            _promotionEngine = new PromotionEngine.PromotionEngine();
        }

        [Test]
        public void TestScenarioA()
        {
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("CSKU");
            Assert.True(_promotionEngine.TotalPrice() == 100);
        }

        [Test]
        public void TestScenarioB()
        {
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("CSKU");
            Assert.True(_promotionEngine.TotalPrice() == 370);
        }

        [Test]
        public void TestScenarioC()
        {
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("ASKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("BSKU");
            _promotionEngine.AddItemToCart("CSKU");
            _promotionEngine.AddItemToCart("DSKU");
            Assert.True(_promotionEngine.TotalPrice() == 280);
        }
    }
}