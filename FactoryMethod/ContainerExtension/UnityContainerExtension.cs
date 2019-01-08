using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace FactoryMethod.ContainerExtension
{
    public static class UnityContainerExtension
    {
        public static void RegisterCarFactory(this IUnityContainer container, string type)
        {
            switch (type)
            {
                case "BmwFactory":
                    container.RegisterType<ICarFactory, BMWFactory>();
                    break;
                case "BugattiFactory":
                    container.RegisterType<ICarFactory, BugattiFactory>();
                    break;
                default:
                    break;
            }
        }
    }
}
