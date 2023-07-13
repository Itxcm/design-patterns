using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.FactoryMethod
{
    /// <summary>
    /// 电子产品 VIP可购买
    /// </summary>
    internal class ElectronicProduct : IProduct
    {
        public string Name => "电子产品";

        public decimal Price => 1000;

        public void Buy(User user)
        {
            Console.WriteLine($"用户{user.Name}购买了{Name},价格为{Price}");
        }

        public bool CanBuy(User user)
        {
            return user.IsVip;
        }
    }

    /// <summary>
    /// 食品 北京商户可购买
    /// </summary>
    internal class FoodProduct : IProduct
    {
        public string Name => "食品";

        public decimal Price => 2000;

        public void Buy(User user)
        {
            Console.WriteLine($"用户{user.Name}购买了{Name},价格为{Price}");
        }

        public bool CanBuy(User user)
        {
            return user.City == "北京";
        }
    }

    /// <summary>
    /// 服饰商品 18岁以上可买
    /// </summary>
    internal class ClothingProduct : IProduct
    {
        public string Name => "服饰";

        public decimal Price => 3000;

        public void Buy(User user)
        {
            Console.WriteLine($"用户{user.Name}购买了{Name},价格为{Price}");
        }

        public bool CanBuy(User user)
        {
            return user.Age >= 18;
        }
    }
}
