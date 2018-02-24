using System;
using System.Collections.Generic;
using System.Linq;

namespace P07AndreyAndBilliard
{
    class Student
    {
        public Dictionary<string, int> ShopList { get; set; }

        public decimal GetBill(Dictionary<string, decimal> productsPrices) // tova e rechnikut za produktite na magazina
        {
            decimal totalBill = 0m;
            foreach (var kvp in ShopList) // proverka na vsichki pokupki na studenta
            {
                if (productsPrices.ContainsKey(kvp.Key)) // ako imeto na produkta, zakupen ot studenta se predlaga ot magazina, to togava...
                {
                    totalBill += kvp.Value * productsPrices[kvp.Key]; // kvp.Value == kolichestvoto ot produkta, zakupeno ot studenta * cenata na tozi produkt
                }
            }
            return totalBill;
        }

        public Student()
        {
            ShopList = new Dictionary<string, int>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> productsPrices = new Dictionary<string, decimal>();
            Dictionary<string, Student> nameStudent = new Dictionary<string, Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                string productName = input[0];
                decimal productPrice = decimal.Parse(input[1]);

                if (productsPrices.ContainsKey(productName) == false)
                {
                    productsPrices.Add(productName, productPrice);
                }
                else
                {
                    productsPrices[productName] = productPrice;
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { '-', ',' });
                if (input[0] == "end of clients")
                {
                    break;
                }
                string name = input[0];
                string product = input[1];
                if (productsPrices.ContainsKey(product) == false) // ako iska da kupi produkt, koito go nqma v magazina
                {
                    continue;
                }
                int quantity = int.Parse(input[2]);

                if (nameStudent.ContainsKey(name) == false) // ako studentut za pruv put se sreshta
                {
                    Student currentStudent = new Student();
                    currentStudent.ShopList.Add(product, quantity); // ako produktut ne sushtestvuva v magazina, nqma da se stigne do tuk
                    nameStudent.Add(name, currentStudent);
                }
                else // ako veche ima takuv student
                {
                    if (nameStudent[name].ShopList.ContainsKey(product) == false) // ako za purvi put si kupuva takuv product
                    {
                        nameStudent[name].ShopList.Add(product, quantity);
                    }
                    else // ako si kupuva produktut za vtori/treti/... put
                    {
                        nameStudent[name].ShopList[product] += quantity; // value na dictionary, koeto e value(ot tip Class) na dictionary..
                    }
                }
            }

            decimal totalBill = 0m;

            foreach (var kvp in nameStudent.OrderBy(x => x.Key)) // podredi po ime
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var kvp2 in nameStudent[kvp.Key].ShopList)
                {
                    Console.WriteLine($"-- {kvp2.Key} - {kvp2.Value}");
                }
                Console.WriteLine($"Bill: {nameStudent[kvp.Key].GetBill(productsPrices):F2}");
                totalBill += nameStudent[kvp.Key].GetBill(productsPrices);
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");

            //main ends here
        }

    }
}

