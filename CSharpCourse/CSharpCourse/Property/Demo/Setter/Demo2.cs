using System;

namespace CSharpCourse.Property.DemoSetter
{
    public class Demo2
    {
        class Tshirt
        {
            private decimal _discount;

            public decimal Price { get; set; }

            public void SetDiscount(decimal d)
            {
                // Vad ska stå här?
                if (d >= 0 && d <= 1)
                {
                    _discount = d;
                }
            }

            public decimal GetDiscount()
            {
                return _discount;
            }
        }

        public static void Run()
        {
            var t = new Tshirt();
            t.Price = 400;
            t.SetDiscount(0.3M); 
            t.SetDiscount(555555555); // här vill vi att inget ska hända
            t.SetDiscount(-4444444);  // här vill vi att inget ska hända

            var priceWithDiscount = t.Price * (1 - t.GetDiscount());

            Console.WriteLine($"Priset för tshirten med rabatt är {priceWithDiscount}kr");

        }
    }
}
