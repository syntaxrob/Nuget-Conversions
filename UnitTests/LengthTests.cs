using System;
using Conversions;
using Xunit;

namespace UnitTests
{
    public class LengthTests
    {
        [Fact]
        public void KilometersAndMeters()
        {
            double expected = 1000;
            double actual = Length.KilometerToMeter(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndCentimeters()
        {
            double expected = 100000;
            double actual = Length.KilometerToCentimeter(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndMillimeters()
        {
            double expected = 1000000;
            double actual = Length.KilometerToMilliimeter(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndMicrometers()
        {
            double expected = 1000000000;
            double actual = Length.KilometerToMicrometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndNanometers()
        {
            double expected = 1000000000000;
            double actual = Length.KilometerToNanometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndMiles()
        {
            double expected = 0.6215040397762586;
            double actual = Length.KilometerToMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndYards()
        {
            double expected = 1094;
            double actual = Length.KilometerToYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndFeet()
        {
            double expected = 3281;
            double actual = Length.KilometerToFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndInch()
        {
            double expected = 39370;
            double actual = Length.KilometerToInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilometersAndNauticalmiles()
        {
            double expected = 0.5399568034557235;
            double actual = Length.KilometerToNauticalMile(1);
            Assert.Equal(expected, actual);
        }
    }
}
