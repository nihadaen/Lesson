namespace ConsApp
{
    public abstract class Product
    {
        private string _name;
        private int _price;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                _price = value;
            }
        }

        public abstract void GetInfo();
    }
}