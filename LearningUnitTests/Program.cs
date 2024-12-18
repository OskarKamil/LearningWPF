using LearningUnitTests.Common;

namespace LearningUnitTests

{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SimpleCalculator simpleCalculator = new SimpleCalculator();
            int a = 17;
            int b = 23;
            Console.WriteLine($"The sum of {a} and {b} is {simpleCalculator.SumTwoIntegers(a, b)}.");
        }
    }
}