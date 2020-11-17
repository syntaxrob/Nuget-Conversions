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

        [Fact]
        public void ImperialMilesPerGallonAndKilometersPerLiter()
        {
            double expected = 0.35398230088495575;
            double actual = FuelEconomy.MilesPerGallonImperialToKilometersPerLiter(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ImperialMilesPerGallonAndLitersPerHundredKm()
        {
            double expected = 282.481;
            double actual = FuelEconomy.MilesPerGallonImperialToLitersPerHundredKm(1);
            Assert.Equal(expected, actual);
        }
    }
}
