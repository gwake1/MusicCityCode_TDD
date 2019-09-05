using System;
using Advanced_TDD.Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
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
    }
}
