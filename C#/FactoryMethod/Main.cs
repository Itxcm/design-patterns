using System;

namespace C_.FactoryMethod
{
    internal class Main
    {
        public static void FactoryMethodDesign()
        {
            User xcm = CreateUser();
            ProductFactory fc = new ElectronicProductFactory();

            if (fc.CurrentProduct.CanBuy(xcm))
            {
                fc.CurrentProduct.Buy(xcm);
            }
            else
            {
                Console.WriteLine($"{xcm.Name}无法购买!");
            }

        }

        private static User CreateUser()
        {
            return new User("徐晨明", 9999, true, "北京", 19);
        }
    }

}
