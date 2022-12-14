
using CalcApp;


namespace CalcApp_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestConstructor()
        {
            Calculator c1 = new Calculator(15);
            Assert.Equal(15,c1.Number);
        }
        //[Fact]
        //public void TestFindFactorial()
        //{
        //    // Test factorial of 4, which is 24
        //    Calculator c1 = new Calculator(4);
        //    int actual = c1.Findfactorial();
        //    Assert.Equal(24, actual);
       // }

        [Theory]
        [InlineData(3,6)]
        [InlineData(4,24)]
        [InlineData(5,120)]
            public void TestFindFactorial(int value, int expected)
            {
            Calculator c1 = new Calculator(value);
            int actual = c1.Findfactorial();
            Assert.Equal(expected, actual);
            }

    }
}