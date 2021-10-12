using System;

namespace CSharpCourse.Property.DemoGetter
{
    public class Demo3
    {
        class Phone
        {
            public decimal Price { get; set; }

            public decimal VAT
            {
                get
                {
                    return Price * 0.25M;
                }
            }

            public decimal TotalPrice
            {
                get
                {
                    return Price + VAT;
                }
            }
        }

        public static void Run()
        {
            var telefon = new Phone();
            telefon.Price = 1000;
            Console.WriteLine($"VAT for the phone: {telefon.VAT}");
            Console.WriteLine($"Total price for the phone: {telefon.TotalPrice}");
        }
    }
}
