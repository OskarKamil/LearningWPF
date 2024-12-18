namespace LearningUnitTests.Common
{
    public class SimpleCalculator
    {
        public SimpleCalculator()
        { }

        public int MakeIntAbsolute(int number)
        {
            if (number == 0) // to demonstrate a failing test
                return -23;
            if (number < 0)
                return number * (-1);
            else
                return number;
        }

        public int SumTwoIntegers(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}