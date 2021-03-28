using System;
using Xunit;

namespace TestOnRasPi
{
    public class UnitTest1
    {
        public int Double(int input)
        {
            return input * 2;
        }

        [Fact]
        public void Test1()
        {
            // arrange
            var input = 4;

            // act
            var doubledInput = Double(input);

            // assert
            Assert.Equal(8, doubledInput);
        }
    }
}
