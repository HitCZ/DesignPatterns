using System;

namespace DesignPatterns.Library_Class
{
    static class MathLibraryClass
    {

        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Power(double a, int exponent) => Math.Pow(a, exponent);

        public static double Divide(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }
    }
}
