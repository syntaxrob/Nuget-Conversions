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

        [Fact]
        public void GradiansAndMilliRadians()
        {
            double expected = 15.707963267948964;
            double actual = PlaneAngle.GradianToMilliradian(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GradiansAndMinutesOfArc()
        {
            double expected = 54;
            double actual = PlaneAngle.GradianToMinuteOfArc(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GradiansAndRadian()
        {
            double expected = 0.015707963267948967;
            double actual = PlaneAngle.GradianToRadian(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GradiansAndSecondOfArc()
        {
            double expected = 3240;
            double actual = PlaneAngle.GradianToSecondOfArc(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilliRadiansAndMinutesOfArc()
        {
            double expected = 3.4377467707849396;
            double actual = PlaneAngle.MilliRadiansToMinuteOfArc(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilliRadiansAndRadians()
        {
            double expected = 0.001;
            double actual = PlaneAngle.MilliRadiansToRadians(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilliRadiansAndSecondsOfArc()
        {
            double expected = 206.26480624709637;
            double actual = PlaneAngle.MilliRadiansToSecondOfArc(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MinutesOfArcAndRadians()
        {
            double expected = 0.0002908882086657216;
            double actual = PlaneAngle.MinuteOfArcToRadians(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MinutesOfArcAndSecondsOfArc()
        {
            double expected = 60;
            double actual = PlaneAngle.MinuteOfArcToSecondOfArc(1);
            Assert.Equal(expected, actual);
        }
    }
}
