// Another example with geometry
using System;

namespace CSharpCourse.Methods.Demo
{
    public class Demo5
    {
        public static void Run()
        {
            //Console.Write("Enter height of triangle1: ");
            //double triangle1Height = double.Parse(Console.ReadLine());

            double triangle1Height = GetPositiveNumber("Enter height of triangle1");
            double triangle1Width = GetPositiveNumber("Enter width of triangle1");

            double triangle2Height = GetPositiveNumber("Enter height of triangle2");
            double triangle2Width = GetPositiveNumber("Enter width of triangle2");



            double area1 = AreaOfTriangle(triangle1Height, triangle1Width);
            double area2 = AreaOfTriangle(triangle2Height, triangle2Width);

            ReportAreaOfTriangle(1, area1);
            ReportAreaOfTriangle(2, area2);
            

        }

        private static void ReportAreaOfTriangle(int shapeNumber, double shapeArea)
        {
            Console.WriteLine($"Area of triangle{shapeNumber} is: {shapeArea}");

        }

        private static double AreaOfTriangle(double height, double width)
        {
            return height * width / 2;
        }

        private static double GetPositiveNumber(string question)
        {
            while (true)
            {
                Console.Write(question + ": ");
                string answer = Console.ReadLine();
                double num;
                if (double.TryParse(answer, out num) && num > 0)
                    return num;
            }
        }
    }
}
