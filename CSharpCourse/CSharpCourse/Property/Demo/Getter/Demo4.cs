using System;

namespace CSharpCourse.Property.DemoGetter
{
    public class Demo4
    {
        // Smidigare att bara använda en pil

        class Phone
        {
            public decimal Price { get; set; }

            public decimal VAT => Price * 0.25M;

            public decimal TotalPrice => Price + VAT;
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
