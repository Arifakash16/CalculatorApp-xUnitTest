namespace SimpleCalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;
            int sum = 8;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(sum, result);
        }


        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 15;
            int b = 3;
            int substract = 12;
            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(substract,result);
        }        

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int num1 = 3;
            int num2 = 6;
            int mul = 18;

            // Act
            int result = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(mul, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int num1 = 20;
            int num2 = 4;
            int quo = 5;

            // Act
            int result = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(quo, result);
        }

        [Fact]
        public void Divide_ShouldThroughArgumentException_WhenDividingByZero()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 0;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(a, b));
        }

    }
}