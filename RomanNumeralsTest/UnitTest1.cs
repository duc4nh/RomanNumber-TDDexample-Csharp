using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestClass]
    public class RomanNumeralsTests
    {
        private RomanNumeral convertor;

        // Use TestInitialize to run code before running each test 
        [TestInitialize]
        public void MyTestInitialize() {
            convertor = new RomanNumeral();
        }

        [TestMethod]
        public void One_is_I()
        {
            // Arrange
            String expectedResult = "I";

            // Act
            String actualResult = convertor.Convert(1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Two_is_II()
        {
            // Arrange
            String expectedResult = "II";

            // Act
            String actualResult = convertor.Convert(2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Three_is_III()
        {
            // Arrange
            String expectedResult = "III";

            // Act
            String actualResult = convertor.Convert(3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
