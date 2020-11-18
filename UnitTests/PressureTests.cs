using System;
using System.Collections.Generic;
using System.Text;
using Conversions.UnitsOfPressure;
using Xunit;

namespace UnitTests
{
    public class PressureTests
    {
        [Fact]
        public void BarAndPascal()
        {
            double expected = 100000;
            double actual = Pressure.BarToPascal(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BarAndPsi()
        {
            double expected = 14.5038;
            double actual = Pressure.BarToPsi(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BarAndAtmosphere()
        {
            double expected = 0.987166831194472;
            double actual = Pressure.BarToAtmosphere(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BarAndTorr()
        {
            double expected = 750;
            double actual = Pressure.BarToTorr(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PascalAndPsi()
        {
            double expected = 0.000145032632342277;
            double actual = Pressure.PascalToPsi(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PascalAndAtmosphere()
        {
            double expected = 9.869232667160129E-06;
            double actual = Pressure.PascalToAtmosphere(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PascalAndTorr()
        {
            double expected = 0.007518796992481203;
            double actual = Pressure.PascalToTorr(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PsiAndAtmospheres()
        {
            double expected = 0.06804572672836146;
            double actual = Pressure.PsiToAtmosphere(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PsiAndTorr()
        {
            double expected = 51.715;
            double actual = Pressure.PsiToTorr(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AtmosphereAndTorr()
        {
            double expected = 760;
            double actual = Pressure.AtmospheresToTorr(1);
            Assert.Equal(expected, actual);
        }
    }
}
