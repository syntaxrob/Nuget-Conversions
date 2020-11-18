using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Conversions.UnitOfFrequency
{
    public class Frequency
    {
        private static class ConstValues
        {
            public const double HtzKhtz = 1000;
            public const double HtzMhtz = 1000000;
            public const double HtzGhtz = 1000000000;
            public const double KhtzMhtz = 1000;
            public const double KhtzGhtz = 1000000;
            public const double MhtzGhtz = 1000;
        }

        /// <summary>
        /// Convert Hertz to Kilohertz
        /// </summary>
        /// <param name="htz"></param>
        /// <returns>Kilohertz</returns>
        public static double HertzToKilohertz(double htz)
        {
            return htz / ConstValues.HtzKhtz;
        }

        /// <summary>
        /// Convert Hertz to Megahertz
        /// </summary>
        /// <param name="htz"></param>
        /// <returns>Megahertz</returns>
        public static double HertzToMegahertz(double htz)
        {
            return htz / ConstValues.HtzMhtz;
        }

        /// <summary>
        /// Convert Hertz to Gigahertz
        /// </summary>
        /// <param name="htz"></param>
        /// <returns>Gigahertz</returns>
        public static double HertzToGigahertz(double htz)
        {
            return htz / ConstValues.HtzGhtz;
        }

        /// <summary>
        /// Convert Kilohertz to Hertz
        /// </summary>
        /// <param name="khtz"></param>
        /// <returns>Hertz</returns>
        public static double KilohertzToHertz(double khtz)
        {
            return khtz * ConstValues.HtzKhtz;
        }

        /// <summary>
        /// Convert Kilohertz to Megahertz
        /// </summary>
        /// <param name="khtz"></param>
        /// <returns>Megahertz</returns>
        public static double KilohertzToMegahertz(double khtz)
        {
            return khtz / ConstValues.KhtzMhtz;
        }

        /// <summary>
        /// Convert Kilohertz to Gigahertz
        /// </summary>
        /// <param name="khtz"></param>
        /// <returns>Gigahertz</returns>
        public static double KilohertzToGigahertz(double khtz)
        {
            return khtz / ConstValues.KhtzGhtz;
        }

        /// <summary>
        /// Convert Megahertz to Hertz
        /// </summary>
        /// <param name="mhtz"></param>
        /// <returns>Hertz</returns>
        public static double MegahertzToHertz(double mhtz)
        {
            return mhtz * ConstValues.HtzMhtz;
        }

        /// <summary>
        /// Convert Megahertz to Kilohertz
        /// </summary>
        /// <param name="mhtz"></param>
        /// <returns>Kilohertz</returns>
        public static double MegahertzToKilohertz(double mhtz)
        {
            return mhtz * ConstValues.HtzKhtz;
        }

        /// <summary>
        /// Convert Megahertz to Gigahertz
        /// </summary>
        /// <param name="mhtz"></param>
        /// <returns>Gigahertz</returns>
        public static double MegahertzToGigahertz(double mhtz)
        {
            return mhtz / ConstValues.MhtzGhtz;
        }

        /// <summary>
        /// Convert Gigahertz to Hertz
        /// </summary>
        /// <param name="ghtz"></param>
        /// <returns>Hertz</returns>
        public static double GigahertzToHertz(double ghtz)
        {
            return ghtz * ConstValues.HtzGhtz;
        }

        /// <summary>
        /// Convert Gigahertz to Kilohertz
        /// </summary>
        /// <param name="ghtz"></param>
        /// <returns>Kilohertz</returns>
        public static double GigahertzToKilohertz(double ghtz)
        {
            return ghtz * ConstValues.KhtzGhtz;
        }

        /// <summary>
        /// Convert Gigahertz to Megahertz
        /// </summary>
        /// <param name="ghtz"></param>
        /// <returns>Megahertz</returns>
        public static double GigahertzToMegahertz(double ghtz)
        {
            return ghtz * ConstValues.MhtzGhtz;
        }
    }
}
