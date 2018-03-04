using System;
using System.Collections.Generic;
using System.Linq;

namespace P07SalesReport
{
    class Sale
    {
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal SaleProfit
        {
            get
            {
                return Price * Quantity;
            }
        }

        public static Sale ReadInput(string product, decimal price, decimal quantity)
        {
            Sale currentSale = new Sale();
            currentSale.Product = product;
            currentSale.Price = price;
            currentSale.Quantity = quantity;
            return currentSale;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> townSale = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string town = input[0];
                string product = input[1];
                decimal price = decimal.Parse(input[2]);
                decimal quantity = decimal.Parse(input[3]);

                if (townSale.ContainsKey(town) == false)
                {
                    Sale currentSale = Sale.ReadInput(product, price, quantity);
                    townSale.Add(town, currentSale.SaleProfit);
                }
                else
                {
                    Sale currentSale = Sale.ReadInput(product, price, quantity);
                    townSale[town] += currentSale.SaleProfit;
                }
            }

            foreach (var kvp in townSale.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }

            //main ends here
        }
    }
}
