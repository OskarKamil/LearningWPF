using LearningUnitTests.Common;

namespace UnitTestsLearning

{
    public class Test1
    {
        [Fact]
        public void MakeIntAbsolute_NegativeNumber_SameNumberButPositive()
        {
            // Arrange
            SimpleCalculator calculator1 = new SimpleCalculator();

            // Act
            int absoluteNumber = calculator1.MakeIntAbsolute(-10);

            // Assert
            Assert.Equal(10, absoluteNumber);
        }

        [Fact]
        public void MakeIntAbsolute_NumberZero_NumberZero()
        {
            // Arrange
            SimpleCalculator calculator1 = new SimpleCalculator();

            // Act
            int absoluteNumber = calculator1.MakeIntAbsolute(0);

            // Assert
            Assert.Equal(0, absoluteNumber);
        }

        [Fact]
        public void MakeIntAbsolute_PositiveNumber_SameNumber()
        {
            // Arrange
            SimpleCalculator calculator1 = new SimpleCalculator();

            // Act
            int absoluteNumber = calculator1.MakeIntAbsolute(6);

            // Assert
            Assert.Equal(6, absoluteNumber);
        }

        [Fact]
        public void SumTwoIntegers_TwoNumbers_SumOfTheNumbers()
        {
            // Arrange
            SimpleCalculator calculator = new SimpleCalculator();

            // Act
            int sum = calculator.SumTwoIntegers(15, 10);

            // Assert
            Assert.Equal(25, sum);
        }
    }
}