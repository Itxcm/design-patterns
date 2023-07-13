using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.FactoryMethod
{
    /// <summary>
    /// 电子商品
    /// </summary>
    internal class ElectronicProductFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return SetProduct(new ElectronicProduct());
        }
        public ElectronicProductFactory()
        {
            CreateProduct();
        }
    }

    /// <summary>
    /// 食品
    /// </summary>
    internal class FoodProductFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return SetProduct(new FoodProduct());
        }
        public FoodProductFactory()
        {
            CreateProduct();
        }
    }

    /// <summary>
    /// 服饰
    /// </summary>
    internal class ClothingProductFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return SetProduct(new ClothingProduct());
        }
        public ClothingProductFactory()
        {
            CreateProduct();
        }
    }
}
