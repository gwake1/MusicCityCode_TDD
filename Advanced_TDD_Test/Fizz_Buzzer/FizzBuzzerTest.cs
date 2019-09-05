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
        [Test]
        public void FizzBuzz_TestTwo()
        {
            // Arrange


            // Act
            var actual = FizzBuzz.Translate(2);

            // Assert
            Assert.That(actual, Is.EqualTo("2"));
        }

        [Test]
        public void FizzBuzz_Translate_Three_ReturnsFizz()
        {
            // Arrange


            // Act
            var actual = FizzBuzz.Translate(3);

            // Assert
            Assert.That(actual, Is.EqualTo("fizz"));
        }

        [Test]
        public void FizzBuzz_Translate_Six_ReturnsFizz()
        {
            // Arrange


            // Act
            var actual = FizzBuzz.Translate(6);

            // Assert
            Assert.That(actual, Is.EqualTo("fizz"));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "buzz")]
        [TestCase(6, "fizz")]
        public void FizzBuzz_Translate_Paramterized_ReturnsFizz(int input, string expected)
        {
            // Arrange


            // Act
            var actual = FizzBuzz.Translate(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase]
        public void FizzBuzz_Translate_15_ReturnsFizzBuzz()
        {
            // Arrange


            // Act
            var actual = FizzBuzz.Translate(15);

            // Assert
            Assert.That(actual, Is.EqualTo("fizzbuzz"));
        }
    }
}
