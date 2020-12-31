
using System;

using Service;

using Xunit;

namespace Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_SameNumberTwice_ResultShouldBeDoubled()
        {
            // ARRANGE
            Calculator calculator = new Calculator();

            // ACT
            int result = calculator.Sum(2, 2);

            // ASSERT
            Assert.Equal(4, result);
        }

        [Fact]
        public void Multiply_TwoRandomNumbers_ResultCorrect()
        {
            // ARRANGE
            Calculator calculator = new Calculator();
            Random rand = new Random();
            int n1 = rand.Next(1, 10);
            int n2 = rand.Next(1, 10);

            // ACT
            int result = calculator.Multiply(n1, n2);

            // ASSERT
            Assert.Equal(n1 * n2, result);
        }
    }
}
