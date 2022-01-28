using System;
using Xunit;

namespace FizzBuzz.Test
{
    public class UnitTest1
    {
        //[Fact]
        //public void ItExist()
        //{
        //    var game = new FizzBuzz.Game();
        //    string output =  game.FizzBuzz(3);
        //    Assert.Equal(string.Empty, output);
        //}
        [Fact]
        public void Given_3_Then_Fizz()
        {
            //Arrange:
            Game game = new Game();
            //Act:
            var result = game.FizzBuzz(3);
            //Assert:
            Assert.Equal("Fizz",result);
        }
        [Fact]
        public void Given_5_Then_Buzz() {
            Game game = new Game();
            //Act:
            var result = game.FizzBuzz(5);
            //Assert:
            Assert.Equal("Buzz", result);
        }


        [Fact]
        public void Given_1_Then_1()
        {
            Game game = new Game();
            //Act:
            var result = game.FizzBuzz(1);
            //Assert:
            Assert.Equal("1", result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        public void Given_Divisible_3_And_Five_Return_Fizzbuzz(int value)
        {
            Game game = new Game();
            //Act:
            var result = game.FizzBuzz(value);
            //Assert:
            Assert.Equal("FizzBuzz", result);
        }



    }
}
