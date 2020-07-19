using System.Globalization;

namespace Propriedades
{
    class Produto
    {
        private string _name;
        
        //Auto prorperties
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Produto()
        {

        }

        public string Name
        {
            get { return _name; }
            set {
                    if (value != null & value.Length > 1)
                    {
                        this._name = value;
                    }
                }
        }        

        public double Amount()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return _name + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " unidades, Total: $ "
                + Amount().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AddProducts(int quantity)
        {
            if (quantity > 0)
            {
                this.Quantity += quantity;
            }
        }

        public void RemoveProducts(int quantity)
        {
            if (this.Quantity > 0)
            {
                if (quantity > 0)
                {
                    this.Quantity -= quantity;
                }
            }
        }
    }
}
