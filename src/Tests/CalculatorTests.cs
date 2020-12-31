
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
    }
}
