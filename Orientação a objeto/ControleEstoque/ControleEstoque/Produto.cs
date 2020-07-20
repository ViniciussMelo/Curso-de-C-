using System.Globalization;

namespace ControleEstoque
{
    class Produto
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double Amount()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Name + ", $"
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
