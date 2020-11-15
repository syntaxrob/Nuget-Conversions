using System;
using System.Collections.Generic;
using System.Text;
using Conversions.UnitsOfTemperature;
using Xunit;

namespace UnitTests
{
    public class TemperatureTests
    {
        [Fact]
        public void CelciusToFarenheit()
        {
            double expected = 33.8;
            double actual = Temperature.CelciusToFarenheit(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CelciusToKelvin()
        {
            double expected = 274.15;
            double actual = Temperature.CelciusToKelvin(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FarenheitToCelcius()
        {
            double expected = -17.22222222222222;
            double actual = Temperature.FarenheitToCelcius(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FarenheitToKelvin()
        {
            double expected = 255.92777777777775;
            double actual = Temperature.FarenheitToKelvin(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KelvinToCelcius()
        {
            double expected = -272.15;
            double actual = Temperature.KelvinToCelcius(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KelvinToFarenheit()
        {
            double expected = -457.86999999999995;
            double actual = Temperature.KelvinToFarenheit(1);
            Assert.Equal(expected, actual);
        }
    }
}
