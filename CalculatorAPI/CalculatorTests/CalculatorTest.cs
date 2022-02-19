using Calculator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        private readonly IMath _math;

        public CalculatorTest()
        {
            var services = new ServiceCollection();
            services.AddTransient<IMath, Math>();
            var serviceProvider = services.BuildServiceProvider();
            _math = serviceProvider.GetService<IMath>();
        }

        [TestMethod]
        public void TestAddition()
        {
            //Arrange
            int expected = 3;
            int i = 1;
            int j = 2;

            //Act
            int result = _math.Addition(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubstraction()
        {
            //Arrange
            int expected = 1;
            int i = 2;
            int j = 1;

            //Act
            int result = _math.Substraction(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            //Arrange
            int expected = 2;
            int i = 2;
            int j = 1;

            //Act
            int result = _math.Multiplication(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            //Arrange
            int expected = 3;
            int i = 6;
            int j = 2;

            //Act
            int result = _math.Division(i, j);

            //Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
