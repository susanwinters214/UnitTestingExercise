using System;
using System.ComponentModel;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5, 5, 5, 15)] //Add test data <-------
        public void Add(int num1, int num2, int num3, int expected)
        {
            var test = new UnitTestMethods();
            var actual = test.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,3,2)]
        [InlineData(15, 7, 8)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            var tester = new UnitTestMethods();
            var actual = tester.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);
         }

        [Theory]
        [InlineData(4,7,28)]
        [InlineData(6, 10, 60)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var test = new UnitTestMethods();
            var actual = test.Multiply(num1, num2);
            Assert.Equal(expected, actual);
    }

        [Theory]
        [InlineData(35,5,7)]
        [InlineData(55, 5, 11)]
        public void DivideTest(int div1, int div2, int expected)
        {
            var tester = new UnitTestMethods();
            var actual = tester.Divide(div1, div2);
            Assert.Equal(expected, actual);
        }

    }
}