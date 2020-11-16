using System;
using System.Collections.Generic;
using System.Text;

namespace Conversions.UnitsOfFuelEconomy
{
    public class FuelEconomy
    {
        private static class ConstValues
        {
            public const double MpgMpgImp = 1.201;
            public const double MpgKpl = 2.352;
            public const double MpgLhkm = 235.215;
            public const double MpgImpKpl = 2.825;
        }

        /// <summary>
        /// Convert Miles per gallon to Imperial Miles per gallon
        /// </summary>
        /// <param name="mpg"></param>
        /// <returns>Imperial Miles per gallon</returns>
        public static double MilesPerGallonToMilesPerGallonImperial(double mpg)
        {
            return mpg * ConstValues.MpgMpgImp;
        }

        /// <summary>
        /// Convert Miles per gallon to Kilometers per liter
        /// </summary>
        /// <param name="mpg"></param>
        /// <returns>Kilometers per liter</returns>
        public static double MilesPerGallonToKilometersPerLitre(double mpg)
        {
            return mpg / ConstValues.MpgKpl;
        }

        /// <summary>
        /// Converts Miles per gallon to Liters per 100 km
        /// </summary>
        /// <param name="mpg"></param>
        /// <returns></returns>
        public static double MilesPerGallonToLitresPerHundredkm(double mpg)
        {
            return ConstValues.MpgLhkm / mpg;
        }
    }
}
