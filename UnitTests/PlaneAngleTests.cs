using System;
using System.Collections.Generic;
using System.Text;
using Conversions.UnitsOfPlaneAngle;
using Xunit;

namespace UnitTests
{
    public class PlaneAngleTests
    {
        [Fact]
        public void DegreesAndGradians()
        {
            double expected = 1.11111111111111;
            double actual = PlaneAngle.DegreeToGradian(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DegreesAndMilliRadians()
        {
            double expected = 17.453292519943293;
            double actual = PlaneAngle.DegreeToMilliradian(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DegreesAndMinutesOfArc()
        {
            double expected = 60;
            double actual = PlaneAngle.DegreeToMinuteOfArc(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DegreesAndRadians()
        {
            double expected = 0.017453292519943295;
            double actual = PlaneAngle.DegreeToRadian(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DegreesAndSecondsOfArc()
        {
            double expected = 3600;
            double actual = PlaneAngle.DegreeToSecondOfArc(1);
            Assert.Equal(expected, actual);
        }
    }
}
