using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Conversions.UnitsOfPressure
{
    public class Pressure
    {
        private static class ConstValues
        {
            public const double BarPascal = 100000;
            public const double BarPsi = 14.5038;
            public const double BarAtmosphere = 1.013;
            public const double BarTorr = 750;
            public const double PascalPsi = 6895;
            public const double PascalAtmosphere = 101325;
            public const double PascalTorr = 133;
            public const double PsiAtmosphere = 14.696;
            public const double PsiTorr = 51.715;
            public const double AtmosphereTorr = 760;
        }

        /// <summary>
        /// Convert Bar to Pascal
        /// </summary>
        /// <param name="bar"></param>
        /// <returns>Pascals</returns>
        public static double BarToPascal(double bar)
        {
            return bar * ConstValues.BarPascal;
        }

        /// <summary>
        /// Convert Bar to Pounds per square inch
        /// </summary>
        /// <param name="bar"></param>
        /// <returns>Pounds per square inch</returns>
        public static double BarToPsi(double bar)
        {
            return bar * ConstValues.BarPsi;
        }

        /// <summary>
        /// Convert Bar to Standard Atmospheres
        /// </summary>
        /// <param name="bar"></param>
        /// <returns>Standard Atmospheres</returns>
        public static double BarToAtmosphere(double bar)
        {
            return bar / ConstValues.BarAtmosphere;
        }

        /// <summary>
        /// Convert Bar to Torr
        /// </summary>
        /// <param name="bar"></param>
        /// <returns>Torr</returns>
        public static double BarToTorr(double bar)
        {
            return bar * ConstValues.BarTorr;
        }

        /// <summary>
        /// Convert Pascals to Bar
        /// </summary>
        /// <param name="pascal"></param>
        /// <returns>Bar</returns>
        public static double PascalToBar(double pascal)
        {
            return pascal / ConstValues.BarPascal;
        }

        /// <summary>
        /// Convert Pascals To PSI
        /// </summary>
        /// <param name="pascal"></param>
        /// <returns>Pounds per square inch</returns>
        public static double PascalToPsi(double pascal)
        {
            return pascal / ConstValues.PascalPsi;
        }

        /// <summary>
        /// Convert Pascals to Standard Atmospheres
        /// </summary>
        /// <param name="pascal"></param>
        /// <returns>Standard Atmospheres</returns>
        public static double PascalToAtmosphere(double pascal)
        {
            return pascal / ConstValues.PascalAtmosphere;
        }

        /// <summary>
        /// Convert Pascals to Torr
        /// </summary>
        /// <param name="pascal"></param>
        /// <returns></returns>
        public static double PascalToTorr(double pascal)
        {
            return pascal / ConstValues.PascalTorr;
        }

        /// <summary>
        /// Convert Psi to Bar
        /// </summary>
        /// <param name="psi"></param>
        /// <returns>Bar</returns>
        public static double PsiToBar(double psi)
        {
            return psi / ConstValues.BarPsi;
        }

        /// <summary>
        /// Convert Psi to Pascal
        /// </summary>
        /// <param name="psi"></param>
        /// <returns>Pascals</returns>
        public static double PsiToPascal(double psi)
        {
            return psi * ConstValues.PascalPsi;
        }

        /// <summary>
        /// Convert Psi to Atmospheres
        /// </summary>
        /// <param name="psi"></param>
        /// <returns>Standard Astmospheres</returns>
        public static double PsiToAtmosphere(double psi)
        {
            return psi / ConstValues.PsiAtmosphere;
        }

        /// <summary>
        /// Convert Psi to Torr
        /// </summary>
        /// <param name="psi"></param>
        /// <returns>Torr</returns>
        public static double PsiToTorr(double psi)
        {
            return psi * ConstValues.PsiTorr;
        }

        /// <summary>
        /// Convert Astmosphere to Bar
        /// </summary>
        /// <param name="psi"></param>
        /// <returns>Bar</returns>
        public static double AtmosphereToBar(double psi)
        {
            return psi * ConstValues.BarAtmosphere;
        }

        /// <summary>
        /// Convert Atmosphere to Pascal
        /// </summary>
        /// <param name="psi"></param>
        /// <returns>Pascal</returns>
        public static double AtmosphereToPascal(double psi)
        {
            return psi * ConstValues.PascalAtmosphere;
        }

        /// <summary>
        /// Convert Astmosphere to Psi
        /// </summary>
        /// <param name="psi"></param>
        /// <returns>Pounds per square inch</returns>
        public static double AtmospheresToPsi(double psi)
        {
            return psi * ConstValues.PsiAtmosphere;
        }

        /// <summary>
        /// Convert Astmospheres to Torr
        /// </summary>
        /// <param name="psi"></param>
        /// <returns>Torr</returns>
        public static double AtmospheresToTorr(double psi)
        {
            return psi * ConstValues.AtmosphereTorr;
        }

        /// <summary>
        /// Convert Torr to Bar
        /// </summary>
        /// <param name="torr"></param>
        /// <returns>Bar</returns>
        public static double TorrToBar(double torr)
        {
            return torr;
        }

        /// <summary>
        /// Convert Torr to Pascal
        /// </summary>
        /// <param name="torr"></param>
        /// <returns>Pascal</returns>
        public static double TorrToPascal(double torr)
        {
            return torr;
        }

        /// <summary>
        /// Convert Torr to Psi
        /// </summary>
        /// <param name="torr"></param>
        /// <returns>Psi</returns>
        public static double TorrToPsi(double torr)
        {
            return torr;
        }

        /// <summary>
        /// Convert Torr to Atmosphere
        /// </summary>
        /// <param name="torr"></param>
        /// <returns>Standard Atmophere</returns>
        public static double TorrToAtmosphere(double torr)
        {
            return torr;
        }
    }
}
