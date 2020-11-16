using System;
using System.Collections.Generic;
using System.Text;
using Conversions.UnitsOfFuelEconomy;
using Xunit;

namespace UnitTests
{
    public class FuelEconomyTests
    {
        [Fact]
        public void MilesPerGallonAndMilesPerGallonImperial()
        {
            double expected = 1.201;
            double actual = FuelEconomy.MilesPerGallonToMilesPerGallonImperial(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilesPerGallonAndKilometersPerLitre()
        {
            double expected = 0.4251700680272109;
            double actual = FuelEconomy.MilesPerGallonToKilometersPerLitre(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MilesPerGallonAndLitresPerHundredkm()
        {
            double expected = 235.215;
            double actual = FuelEconomy.MilesPerGallonToLitresPerHundredkm(1);
            Assert.Equal(expected, actual);
        }
    }
}
