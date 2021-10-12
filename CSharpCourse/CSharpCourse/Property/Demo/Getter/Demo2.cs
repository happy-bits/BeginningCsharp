using System;

namespace CSharpCourse.Property.DemoGetter
{
    public class Demo2
    {
        class Phone
        {
            public decimal Price { get; set; }

            public decimal GetVAT()
            {
                return Price * 0.25M;
            }

            public decimal GetTotalPrice()
            {
                return Price + GetVAT();
            }
        }

        public static void Run()
        {
            var telefon = new Phone();
            telefon.Price = 1000;
            Console.WriteLine($"VAT for the phone: {telefon.GetVAT()}");
            Console.WriteLine($"Total price for the phone: {telefon.GetTotalPrice()}");
        }
    }
}
