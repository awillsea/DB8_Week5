using PracticePart1;

namespace PracticePart1_Test
{

    public class UnitTest1
    {
        [Theory]
        [InlineData(-1, -1)]
        [InlineData(-2, -1)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]

        public void Test1(int value, int expected)
        {
            int actual = Coupoun.GetSign(value);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(5.0, 0)]
        [InlineData(9.99,0.0)]
        [InlineData(10.0,2.0)]
        [InlineData(19.99, 2.0)]
        [InlineData(20.01, 3.0)]
        [InlineData(100.00, 3.0)]

        public void TestCalcupuon(decimal value, decimal expect)
        {
            decimal actual = Coupoun.CalculateCupon(value);
            Assert.Equal(expect, actual);
        }



    }
}