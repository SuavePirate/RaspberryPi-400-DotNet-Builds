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
        public void DoublePass()
        {
            // arrange
            var input = 4;

            // act
            var doubledInput = Double(input);

            // assert
            Assert.Equal(8, doubledInput);
        }

        [Fact]
        public void DoubleFail()
        {
            // arrange
            var input = 615619;

            // act
            var doubledInput = Double(input);

            // assert
            Assert.Equal(1231238, doubledInput);
        }
    }
}
