using System;

namespace CSharpCourse.Property.DemoSetter
{
    public class Demo3
    {
        class Tshirt
        {
            private decimal _discount;

            public decimal Price { get; set; }

            public decimal Discount
            {
                get => _discount;
                set 
                {
                    if (value >= 0 && value <= 1)
                    {
                        _discount = value;
                    }
                }
            }

        }

        public static void Run()
        {
            var t = new Tshirt();
            t.Price = 400;
            t.Discount = 0.3M; 
            t.Discount = 555555555; // här vill vi att inget ska hända
            t.Discount = -4444444;  // här vill vi att inget ska hända

            var priceWithDiscount = t.Price * (1 - t.Discount);

            Console.WriteLine($"Priset för tshirten med rabatt är {priceWithDiscount}kr");

        }
    }
}
