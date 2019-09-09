using System;
using Advanced_TDD.PairProgram_FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Advanced_TDD_Test.PairProgramFizzBuzzer_Test
{
    [TestFixture]
    public class PairProgramFizzBuzzerTest
    {
        [Test]
        public void FizzBuzz_Speak_1_ReturnsOne()
        {
            // Arrange

            // Act
            var actual = PairProgramFizzBuzz.Speak(1);


            // Assert
            Assert.That(actual, Is.EqualTo("1"));
        }

        [Test]
        public void FizzBuzz_Speak_3_ReturnsFizz()
        {
            // Arrange

            // Act
            var actual = PairProgramFizzBuzz.Speak(3);


            // Assert
            Assert.That(actual, Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzz_Speak_5_ReturnsBuzz()
        {
            // Arrange

            // Act
            var actual = PairProgramFizzBuzz.Speak(5);


            // Assert
            Assert.That(actual, Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzz_Speak_2_ReturnsTwo()
        {
            // Arrange

            // Act
            var actual = PairProgramFizzBuzz.Speak(2);


            // Assert
            Assert.That(actual, Is.EqualTo("2"));
        }

        [Test]
        public void FizzBuzz_Speak_15_ReturnsFizzBuzz()
        {
            // Arrange

            // Act
            var actual = PairProgramFizzBuzz.Speak(15);


            // Assert
            Assert.That(actual, Is.EqualTo("FizzBuzz"));
        }
    }
}
