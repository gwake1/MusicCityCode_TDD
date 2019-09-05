using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Advanced_TDD.Fizz_Buzz;

namespace Advanced_TDD_Test.Fizz_Buzzer
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void FizzBuzz_TestOne()
        {
            // Arrange


            // Act
            var actual = FizzBuzz.Translate(1);

            // Assert
            Assert.That(actual, Is.EqualTo("1"));
        }
    }
}
