using PigLatin;

namespace PigLatin_Tests
{
    public class UnitTest1
    {
        //[Fact]
        //public void TestisavowelA()
        //{
        //    bool actual = Translator.isVowel('a');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestisavowelE()
        //{
        //    bool actual = Translator.isVowel('e');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestisavowelI()
        //{
        //    bool actual = Translator.isVowel('i');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestisavowelO()
        //{
        //    bool actual = Translator.isVowel('o');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestisavowelU()
        //{
        //    bool actual = Translator.isVowel('u');
        //    Assert.True(actual);
        //}
        [Theory]
        [InlineData('a')]
        [InlineData('e')]
        [InlineData('i')]
        [InlineData('o')]
        [InlineData('u')]

        public void Testisvowel(char value)
        {
            bool actual = Translator.isVowel(value);
            Assert.True(actual);
        }
        [Fact]
        public void Testisavowels()
        {
            bool actual = Translator.isVowel('s');
            Assert.False(actual);
        }
        [Fact]
        public void Testisavowelz()
        {
            bool actual = Translator.isVowel('z');
            Assert.False(actual);
        }

        [Fact]
        public void TestStartsWithVowel()
        {
            bool actual = Translator.StartswithVowel("apple");
            Assert.True(actual);

        }
        [Fact]
        public void TestStartsWithCons()
        {
            bool actual = Translator.StartswithVowel("school");
            Assert.False(actual);
        }

        [Fact]
        public void TestNumCons1()
        {
            int actual = Translator.NumberofCons("banana");
            Assert.Equal(1, actual);
        }
        [Fact]
        public void TestNumCons2()
        {
            int actual = Translator.NumberofCons("shout");
            Assert.Equal(2, actual);
        }
        [Fact]
        public void TestNumCons3()
        {
            int actual = Translator.NumberofCons("school");
            Assert.Equal(3, actual);
        }
        [Fact]
        public void testNumCons4()
        {
            int actual = Translator.NumberofCons("rhythm");
            Assert.Equal(6, actual);
        }
        [Fact]
        public void TestPLVowel1()
        {
            string actual = Translator.PigLatinVowels("apple");
            Assert.Equal("appleyay",actual);
        }
        [Fact]
        public void TestPLVowel2()
        {
            string actual = Translator.PigLatinVowels("every");
            Assert.Equal("everyyay", actual);
        }
        
        //public void TestPLCons1()
        //{
        //    string actual = Translator.PigLatinCons("school");
        //    Assert.Equal("oolschay", actual);
        //}
        //[Fact]
        //public void TestPLCons2()
        //{
        //    string actual = Translator.PigLatinCons("something");
        //    Assert.Equal("omethingsay", actual);
        // }
        [Theory]
        [InlineData("school","oolschay")]
        [InlineData("something","omethingsay")]
        [InlineData("rhythm","rhythmay")]
        public void TestPigLatingcons(string value, string expected)
        {
            string actual = Translator.PigLatinCons(value);
            Assert.Equal(expected, actual); 
        }
     
       
        [Fact]
        public void TestPigLatin1()
        {
            string actually = Translator.Piglatinize("eat");
            Assert.Equal("eatyay", actually);
        }
        [Fact]
        public void TestPigLatin2()
        {
            string actually = Translator.Piglatinize("banana");
            Assert.Equal("ananabay", actually);
        }
       


    }
}