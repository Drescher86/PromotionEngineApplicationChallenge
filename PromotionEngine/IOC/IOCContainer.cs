using Castle.MicroKernel.Registration;
using Castle.Windsor;
using PromotionEngine.Promotions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.IOC
{
    public class IOCContainer
    {
        private WindsorContainer _container;

        public IOCContainer()
        {
            _container = new WindsorContainer();
            _container.Register(Component.For<IPromotionsCalculator>().ImplementedBy<PromotionsCalculator>());
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
