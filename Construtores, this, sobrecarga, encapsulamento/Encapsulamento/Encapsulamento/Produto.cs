using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        private string _name;
        private double _price;
        private int _quantity;

        public Produto()
        {
            
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (name != null & name.Length > 1)
            {
                this._name = name;
            }
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public double Amount()
        {
            return _quantity * _price;
        }

        public override string ToString()
        {
            return _name + ", $"
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantity
                + " unidades, Total: $ "
                + Amount().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AddProducts(int quantity)
        {
            if (quantity > 0)
            {
                this._quantity += quantity;
            }
        }

        public void RemoveProducts(int quantity)
        {
            if (this._quantity > 0)
            {
                if (quantity > 0)
                {
                    this._quantity -= quantity;
                }
            }
        }
    }
}
