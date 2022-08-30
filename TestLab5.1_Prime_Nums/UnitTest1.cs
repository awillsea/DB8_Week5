using Lab_5._1_Find_PrimeNums;
namespace TestLab5._1_Prime_Nums
{
    public class UnitTest1
    {
        [Theory]
        
        [InlineData(4,7)]
        [InlineData(5,11)]
        [InlineData(100,541)]
        [InlineData(421, 2909)]
        [InlineData(15, 47)]
        [InlineData(42, 181)]


        public void TestGetPrime10(int value, int expected)
        {
            int actual = Lab5_1.GetPrime(value);
            Assert.Equal(expected, actual);
        }
    }
}