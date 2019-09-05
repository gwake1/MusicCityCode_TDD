using Advanced_TDD.Calculator;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace Advanced_TDD_Test
{
    [TestFixture]
    public class AdderTest
    {
        [Test]
        public void Adder_Add_ZeroPlusZero_ShouldReturnZero()
        {
            // Arrange
            var adder = new Adder();
            var addend = 0;
            var augend = 0;

            // Act
            int actual = adder.Add(addend, augend);

            // Assert
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Adder_Add_NegativeAddendLessThanAugend_ShouldTrowException()
        {
            // Arrange
            var adder = new Adder();
            var addend = -1;
            var augend = 1;

            // Act
            Action actual = () => adder.Add(addend, augend);

            // Assert
            Assert.That(actual, Throws.ArgumentException);
        }

        [Test]
        public void Adder_Add_NegativeAugendLessThanAddend_ShouldTrowException()
        {
            // Arrange
            var adder = new Adder();
            var addend = 1;
            var augend = -1;

            // Act
            Action actual = () => adder.Add(addend, augend);

            // Assert
            Assert.That(actual, Throws.ArgumentException);
        }

        [Test]
        public void Adder_Add_NullAugendPlusOne_ShoudReturnOne()
        {
            // Arrange
            var adder = new Adder();
            int? addend = null;
            int augend = 1;

            // Act
            var actual = adder.Add(addend, augend);

            // Assert
            var expected = 1;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Adder_Add_NullAddendPlusOne_ShoudReturnOne()
        {
            // Arrange
            var adder = new Adder();
            int? addend = 1;
            int? augend = null;

            // Act
            var actual = adder.Add(addend, augend);

            // Assert
            var expected = 1;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}