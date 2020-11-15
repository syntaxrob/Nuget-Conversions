using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Conversions.UnitsOfSpeed;

namespace UnitTests
{
    public class SpeedTests
    {
        [Fact]
        public void MphAndFps()
        {
            double expected = 1.467;
            double actual = Speed.MilesPerHourToFeetPerSecond(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MphAndMps()
        {
            double expected = 0.44702726866338843;
            double actual = Speed.MilesPerHourToMetersPerSecond(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MphAndKph()
        {
            double expected = 1.609;
            double actual = Speed.MilesPerHourToKilometersPerHour(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MphAndKnots()
        {
            double expected = 0.8688097306689835;
            double actual = Speed.MilesPerHourToKnots(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FpsAndMps()
        {
            double expected = 0.30478512648582745;
            double actual = Speed.FeetPerSecondToMetersPerSecond(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FpsAndKph()
        {
            double expected = 1.097;
            double actual = Speed.FeetPerSecondToKilometersPerHour(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FpsAndKnots()
        {
            double expected = 0.5924170616113744;
            double actual = Speed.FeetPerSecondToKnots(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MpsAndKph()
        {
            double expected = 3.6;
            double actual = Speed.MetersPerSecondToKilometersPerHour(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MpsAndKnots()
        {
            double expected = 1.944;
            double actual = Speed.MetersPerSecondToKnots(1);
            Assert.Equal(expected, actual);
        }
    }
}
