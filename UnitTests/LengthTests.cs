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

        [Fact]
        public void MetersAndCentimeters()
        {
            double expected = 100;
            double actual = Length.MeterToCentimeter(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MetersAndMillimeters()
        {
            double expected = 1000;
            double actual = Length.MeterToMillimeter(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MetersAndMicrometers()
        {
            double expected = 1000000;
            double actual = Length.MeterToMicrometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MetersAndNanometers()
        {
            double expected = 1000000000;
            double actual = Length.MeterToNanometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MetersAndMiles()
        {
            double expected = 0.0006215040397762585;
            double actual = Length.MeterToMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MetersAndYards()
        {
            double expected = 1.094;
            double actual = Length.MeterToYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MetersAndFeet()
        {
            double expected = 3.281;
            double actual = Length.MeterToFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MetersAndInches()
        {
            double expected = 39.37;
            double actual = Length.MeterToInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MetersAndNauticalmiles()
        {
            double expected = 0.0005399568034557236;
            double actual = Length.MeterToNauticalmile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CentimetersAndMillimeters()
        {
            double expected = 10;
            double actual = Length.CentimeterToMillimeter(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CentimetersAndMicrometers()
        {
            double expected = 10000;
            double actual = Length.CentimeterToMicrometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CentimetersAndNanometers()
        {
            double expected = 10000000;
            double actual = Length.CentimeterToNanometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CentimetersAndMiles()
        {
            double expected = 0.000006213727366498068;
            double actual = Length.CentimeterToMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CentimetersAndYards()
        {
            double expected = 0.010936132983377079;
            double actual = Length.CentimeterToYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CentimetersAndFeet()
        {
            double expected = 0.03280839895013123;
            double actual = Length.CentimeterToFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CentimetersAndInches()
        {
            double expected = 0.39370078740157477;
            double actual = Length.CentimeterToInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CentimetersAndNauticalmiles()
        {
            double expected = 0.000005399568034557236;
            double actual = Length.CentimeterToNauticalMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MillimetersAndMicrometers()
        {
            double expected = 1000;
            double actual = Length.MillimeterToMicrometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MillimetersAndNanometers()
        {
            double expected = 1000000;
            double actual = Length.MillimeterToNanometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MillimetersAndMiles()
        {
            double expected = 0.0000006215040397762585;
            double actual = Length.MillimeterToMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MillimetersAndYards()
        {
            double expected = 0.0010940919037199124;
            double actual = Length.MillimeterToYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MillimetersAndFeet()
        {
            double expected = 0.003278688524590164;
            double actual = Length.MillimeterToFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MillimetersAndInches()
        {
            double expected = 0.03937007874015748;
            double actual = Length.MillimeterToInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MillimetersAndNauticalmiles()
        {
            double expected = 0.0000005399568034557235;
            double actual = Length.MillimeterToNauticalmile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MicrometersAndNanometers()
        {
            double expected = 1000;
            double actual = Length.MicrometerToNanometer(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MicrometersAndMiles()
        {
            double expected = 0.0000000006215040397762586;
            double actual = Length.MicrometerToMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MicrometersAndYards()
        {
            double expected = 0.0000010936132983377078;
            double actual = Length.MicrometerToYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MicrometersAndFeet()
        {
            double expected = 0.0000032808398950131235;
            double actual = Length.MicrometerToFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MicrometersAndInches()
        {
            double expected = 0.00003937007874015748;
            double actual = Length.MicrometerToInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MicrometersAndNauticalmiles()
        {
            double expected = 0.0000000005399568034557236;
            double actual = Length.MicrometerToNauticalmile(1);
            Assert.Equal(expected, actual);
        }

        [Fact] 
        public void NanometersAndMiles()
        {
            double expected = 0.0000000000006215040397762585;
            double actual = Length.NanometerToMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NanometersAndYards()
        {
            double expected = 0.0000000010936132983377077;
            double actual = Length.NanometerToYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NanometersAndFeet()
        {
            double expected = 0.0000000032808398950131233;
            double actual = Length.NanometerToFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NanometersAndInches()
        {
            double expected = 0.00000003937007874015748;
            double actual = Length.NanometerToInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NanometersAndNauticalmiles()
        {
            double expected = 0.0000000000005399568034557235;
            double actual = Length.NanometerToNauticalMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilesAndYards()
        {
            double expected = 1760;
            double actual = Length.MileToYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilesAndFeet()
        {
            double expected = 5280;
            double actual = Length.MileToFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilesAndInches()
        {
            double expected = 63360;
            double actual = Length.MileToInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilesAndNauticalMiles()
        {
            double expected = 0.8688097306689835;
            double actual = Length.MileToNauticalmile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YardsAndFeet()
        {
            double expected = 3;
            double actual = Length.YardToFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YardsAndInches()
        {
            double expected = 36;
            double actual = Length.YardtoInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YardsAndNauticalmiles()
        {
            double expected = 0.0004938271604938272;
            double actual = Length.YardToNauticalmile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FeetAndInches()
        {
            double expected = 12;
            double actual = Length.FootToInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FeetAndNauticalmiles()
        {
            double expected = 0.00016458196181698485;
            double actual = Length.FootToNauticalmile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InchesAndNauticalmiles()
        {
            double expected = 0.00001371497538161919;
            double actual = Length.InchToNauticalmile(1);
            Assert.Equal(expected, actual);
        }
    }
}
