using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.FactoryMethod
{
    /// <summary>
    ///  抽象商品工厂类
    /// </summary>
    internal abstract class ProductFactory
    {
        private IProduct _currentProduct;

        public IProduct CurrentProduct
        {
            get => _currentProduct;
            private set => _currentProduct = value;
        }

        public abstract IProduct CreateProduct();

        public IProduct SetProduct(IProduct product) => _currentProduct = product;
    }
}
