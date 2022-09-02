using Calculator.Lib;
using Moq;

namespace TDD.xUnit
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            
            decimal num1 = 10;
            decimal num2 = 5;
            decimal expected_value=15;
            var calculator = new FakeCalculator();
            var actual_value=calculator.Add(num1, num2);   
            Assert.Equal(expected_value, actual_value);


        }
        [Fact]
        public void MultiplyTest()
        {
            var calculator = new FakeCalculator();
            Assert.Equal(6, calculator.Multiply(2,3));


        }
        [Fact]
        public void MockAddTest()
        {
            decimal mockNum1 = 20;
            decimal mockNum2 = 10;
            decimal expected_value=30;
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(mockNum1, mockNum2)).Returns(expected_value);
            var actual_value=calculator.Object.Add(mockNum1, mockNum2);
            Assert.Equal(expected_value,actual_value);


        }

    }
}