using System;
using System.Collections.Generic;
using System.Text;
using Conversions.UnitOfFrequency;
using Xunit;

namespace UnitTests
{
    public class FrequencyTests
    {
        [Fact]
        public void HertzAndKilohertz()
        {
            double expected = 0.001;
            double actual = Frequency.HertzToKilohertz(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HertzAndMegahertz()
        {
            double expected = 0.000001;
            double actual = Frequency.HertzToMegahertz(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HertzAndGigahertz()
        {
            double expected = 0.000000001;
            double actual = Frequency.HertzToGigahertz(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilohertzAndMegahertz()
        {
            double expected = 0.001;
            double actual = Frequency.KilohertzToMegahertz(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void KilohertzAndGigahertz()
        {
            double expected = 0.000001;
            double actual = Frequency.KilohertzToGigahertz(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MegahertzAndGigahertz()
        {
            double expected = 0.001;
            double actual = Frequency.MegahertzToGigahertz(1);
            Assert.Equal(expected, actual);
        }
    }
}
