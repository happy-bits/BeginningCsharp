using System;

namespace CSharpCourse.Property.DemoGetter
{
    public class Demo1
    {
        class Phone
        {
            public decimal Price { get; set; }
            public decimal VAT { get; set; }           
            public decimal TotalPrice { get; set; }     
        }

        public static void Run()
        {
            var telefon = new Phone();
            telefon.Price = 1000;
            telefon.VAT = 250;
            telefon.TotalPrice = 1250;  // problem: denna kan av misstag sättas till något felaktigt
            Console.WriteLine($"Total price for the phone: {telefon.TotalPrice}");
        }
    }
}
