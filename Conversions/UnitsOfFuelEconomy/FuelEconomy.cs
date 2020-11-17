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
            public const double MpgImpLhkm = 282.481;
            public const double KplLhkm = 100;
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
        /// <returns>Liters per 100 km</returns>
        public static double MilesPerGallonToLitresPerHundredkm(double mpg)
        {
            return ConstValues.MpgLhkm / mpg;
        }

        /// <summary>
        /// Convert Imperial Miles per gallon to Miles per gallon
        /// </summary>
        /// <param name="mpgImp"></param>
        /// <returns>Miles per gallon</returns>
        public static double MilesPerGallonImperialToMilesPerGallon(double mpgImp)
        {
            return mpgImp / ConstValues.MpgMpgImp;
        }

        /// <summary>
        /// Convert Imperial miles per gallon to Kilometers per liter
        /// </summary>
        /// <param name="mpgImp"></param>
        /// <returns>Kilometers per liter</returns>
        public static double MilesPerGallonImperialToKilometersPerLiter(double mpgImp)
        {
            return mpgImp / ConstValues.MpgImpKpl;
        }

        /// <summary>
        /// Converts Imperial miles per gallon to Liters per 100 km
        /// </summary>
        /// <param name="mpgImp"></param>
        /// <returns>Liters per 100 km</returns>
        public static double MilesPerGallonImperialToLitersPerHundredKm(double mpgImp)
        {
            return mpgImp * ConstValues.MpgImpLhkm;
        }

        /// <summary>
        /// Convert Kilometers per liter to Miles per gallon
        /// </summary>
        /// <param name="kpl"></param>
        /// <returns>Miles per gallon</returns>
        public static double KilometersPerLiterToMilesPerGalon(double kpl)
        {
            return kpl * ConstValues.MpgKpl;
        }

        /// <summary>
        /// Convert Kilometers per liter to Imperial miles per gallon
        /// </summary>
        /// <param name="kpl"></param>
        /// <returns>Imperial miles per gallon</returns>
        public static double KilometersPerLiterToImperialMilesPerGalon(double kpl)
        {
            return kpl * ConstValues.MpgImpKpl;
        }

        /// <summary>
        /// Convert Kilometers per liter to Liters per 100 km
        /// </summary>
        /// <param name="kpl"></param>
        /// <returns></returns>
        public static double KilometersPerLiterToLitersPerHundredKm(double kpl)
        {
            return ConstValues.KplLhkm / kpl;
        }

        /// <summary>
        /// Converts Liters per hundred km to Miles per gallon
        /// </summary>
        /// <param name="lphkm"></param>
        /// <returns>Miles per gallon</returns>
        public static double LitersPerHundredKmToMilesPerGallon(double lphkm)
        {
            return ConstValues.MpgLhkm / lphkm;
        }

        /// <summary>
        /// Converts Liters per hundred km to Imperial miles per gallon
        /// </summary>
        /// <param name="lphkm"></param>
        /// <returns>Imperial miles per gallon</returns>
        public static double LitersPerHundredKmToImperialMilesPerGallon(double lphkm)
        {
            return ConstValues.MpgImpLhkm / lphkm;
        }

        /// <summary>
        /// Converts Liters per 100km to Kilometers per liter
        /// </summary>
        /// <param name="lphkm"></param>
        /// <returns></returns>
        public static double LitersPerHundredKmToKilometersPerLiter(double lphkm)
        {
            return ConstValues.KplLhkm / lphkm;
        }
    }
}
