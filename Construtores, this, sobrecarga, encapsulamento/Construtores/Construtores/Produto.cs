using System.Globalization;

namespace Construtores
{
    class Produto
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Produto()
        {
            Quantity = 10;
        }

        //Chama o construtor de cima
        public Produto (string name, double price) : this()
        {
            this.Name = name;
            this.Price = price;
        }

        public Produto(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

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
