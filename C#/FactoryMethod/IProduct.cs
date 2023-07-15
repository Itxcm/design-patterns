namespace C_.FactoryMethod
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class User
    {
        private int _id = 0;
        private string _name;
        private decimal _price;
        private bool _isVip;
        private string _city;
        private int _age;

        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public decimal Price
        {
            get => _price;
            private set => _price = value;
        }

        public bool IsVip
        {
            get => _isVip;
            private set => _isVip = value;
        }

        public string City
        {
            get => _city;
            private set => _city = value;
        }

        public int Age
        {
            get => _age;
            private set => _age = value;
        }

        public User(string name, decimal price, bool isVip, string City, int age)
        {
            _id = ++_id;
            _name = name;
            _price = price;
            _isVip = isVip;
            _city = City;
            _age = age;
        }
    }

    /// <summary>
    /// 商品接口
    /// </summary>
    internal interface IProduct
    {
        string Name { get; }

        decimal Price { get; }

        bool CanBuy(User user);

        void Buy(User user);
    }
}