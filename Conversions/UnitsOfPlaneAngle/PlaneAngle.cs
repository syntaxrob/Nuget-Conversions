using System;
using System.Collections.Generic;
using System.Text;

namespace Conversions.UnitsOfPlaneAngle
{
    public class PlaneAngle
    {
        private static class ConstValues
        {
            public const double DegGrad = 1.11111111111111;
            public const double Pi = 3.14159265358979323846;
            public const double DegMoa = 60;
            public const double DegSoa = 3600;
        }

        /// <summary>
        /// Convert Degrees to Gradians
        /// </summary>
        /// <param name="deg"></param>
        /// <returns>Gradians</returns>
        public static double DegreeToGradian(double deg)
        {
            return deg * ConstValues.DegGrad;
        }

        /// <summary>
        /// Convert Degrees to Millirads
        /// </summary>
        /// <param name="deg"></param>
        /// <returns>Millirads</returns>
        public static double DegreeToMilliradian(double deg)
        {
            return deg * ((1000 * ConstValues.Pi) / 180);
        }

        /// <summary>
        /// Convert Degrees to Minute of Arc
        /// </summary>
        /// <param name="deg"></param>
        /// <returns>Minute of Arc</returns>
        public static double DegreeToMinuteOfArc(double deg)
        {
            return deg * ConstValues.DegMoa;
        }

        /// <summary>
        /// Convert Degrees to Radians
        /// </summary>
        /// <param name="deg"></param>
        /// <returns>Radians</returns>
        public static double DegreeToRadian(double deg)
        {
            return deg * (ConstValues.Pi / 180);
        }

        /// <summary>
        /// Convert Degrees to Second of Arc
        /// </summary>
        /// <param name="deg"></param>
        /// <returns>Second of Arc</returns>
        public static double DegreeToSecondOfArc(double deg)
        {
            return deg * ConstValues.DegSoa;
        }
    }
}
