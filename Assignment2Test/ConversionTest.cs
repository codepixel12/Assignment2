using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2;

namespace Assignment2Test
{
    public class ConversionTest
    {
        //Test ConvertCelciusToFahrenheit
        [Test]
        public void CelciusToFahrenheitZeroPositiveVal()
        {
            var conversion = new Conversion(10);
            //Arrange
            double actualResult = conversion.ConvertCelciusToFahrenheit();

            //Act
            double expectedResult = 50;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CelciusToFahrenheitZero()
        {
            var conversion = new Conversion(0);
            //Arrange
            double actualResult = conversion.ConvertCelciusToFahrenheit();
            //Act
            double expectedResult = 32;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CelciusToFahrenheitDefault()
        {
            var conversion = new Conversion();
            //Arrange
            double actualResult = conversion.ConvertCelciusToFahrenheit();
            //Act
            double expectedResult = 33;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Test ConvertCelciusToKelvin
        [Test]
        public void ConvertCelciusToKelvinPositiveVal()
        {
            var conversion = new Conversion(10);
            //Arrange
            double actualResult = conversion.ConvertCelciusToKelvin();
            //Act
            double expectedResult = 283.15;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ConvertCelciusToKelvinZero()
        {
            var conversion = new Conversion(0);
            //Arrange
            double actualResult = conversion.ConvertCelciusToKelvin();
            //Act
            double expectedResult = 273.15;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ConvertCelciusToKelvinDefault()
        {
            var conversion = new Conversion(0);
            //Arrange
            double actualResult = conversion.ConvertCelciusToKelvin();
            //Act
            double expectedResult = 273.15;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Test ConvertFahrenheitToCelcius
        [Test]
        public void ConvertFahrenheitToCelciusPositiveVal()
        {
            var conversion = new Conversion(32);
            //Arrange
            double actualResult = conversion.ConvertFahrenheitToCelcius();
            //Act
            double expectedResult = 0;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ConvertFahrenheitToCelciusZero()
        {
            var conversion = new Conversion(0);
            //Arrange
            double actualResult = conversion.ConvertFahrenheitToCelcius();
            //Act
            double expectedResult = 0;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ConvertFahrenheitToCelciusDefault()
        {
            var conversion = new Conversion();
            //Arrange
            double actualResult = conversion.ConvertFahrenheitToCelcius();
            //Act
            double expectedResult = 0;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        //Test ConvertFahrenheitToKelvin
        [Test]
        public void ConvertFahrenheitToKelvinPositiveVal()
        {
            var conversion = new Conversion(32);
            //Arrange
            double actualResult = conversion.ConvertFahrenheitToKelvin();
            //Act
            double expectedResult = 273;
            //Assert
            Assert.AreEqual(expectedResult, Math.Round(actualResult));
        }

        [Test]
        public void ConvertFahrenheitToKelvinZero()
        {
            var conversion = new Conversion(0);
            //Arrange
            double actualResult = conversion.ConvertFahrenheitToKelvin();
            //Act
            double expectedResult = 255;
            //Assert
            Assert.AreEqual(expectedResult, Math.Round(actualResult));
        }
        [Test]
        public void ConvertFahrenheitToKelvinDefault()
        {
            var conversion = new Conversion();
            //Arrange
            double actualResult = conversion.ConvertFahrenheitToKelvin();
            //Act
            double expectedResult = 256;
            //Assert
            Assert.AreEqual(expectedResult, Math.Round(actualResult));
        }

        //Test KelvinToFahrenhit
        [Test]
        public void ConvertKelvinToFahrenhitPositiveVal()
        {
            var conversion = new Conversion(25);

            double result = conversion.ConvertKelvinToFahrenheit();

            double expectedResult = -415;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void ConvertKelvinToFahrenhitZero()
        {
            var conversion = new Conversion(0);

            double result = conversion.ConvertKelvinToFahrenheit();

            double expectedResult = -460;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        [Test]
        public void ConvertKelvinToFahrenhitDefault()
        {
            var conversion = new Conversion();

            double result = conversion.ConvertKelvinToFahrenheit();

            double expectedResult = -458;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }

        //Test ConvertKelvinToCelcius
        [Test]
        public void ConvertKelvinToCelciusPositiveVal()
        {
            var conversion = new Conversion(90);

            double result = conversion.ConvertKelvinToCelcius();

            double expectedResult = -183;

            Assert.AreEqual(expectedResult, Math.Round(result));

        }

        [Test]
        public void ConvertKelvinToCelciusZero()
        {
            var conversion = new Conversion(0);

            double result = conversion.ConvertKelvinToCelcius();

            double expectedResult = -273;

            Assert.AreEqual(expectedResult, Math.Round(result));

        }

        [Test]
        public void ConvertKelvinToCelciusDefault()
        {
            var conversion = new Conversion();

            double result = conversion.ConvertKelvinToCelcius();

            double expectedResult = -272;

            Assert.AreEqual(expectedResult, Math.Round(result));
        }
                
    }
}
