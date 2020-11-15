using System;
using System.Collections.Generic;
using System.Text;

namespace Conversions.UnitsOfSpeed
{
    public class Speed
    {
        private static class ConstValues
        {
            public const double Mphfps = 1.467;
            public const double Mphmps = 2.237;
            public const double Mphkph = 1.609;
            public const double Mphknot = 1.151;
            public const double Fpsmps = 3.281;
            public const double Fpskph = 1.097;
            public const double Fpsknot = 1.688;
            public const double Mpskph = 3.6;
            public const double Mpsknot = 1.944;
            public const double Kphknot = 1.852;
        }

        /// <summary>
        /// Convert Miles per hour to Feet per second
        /// </summary>
        /// <param name="mph"></param>
        /// <returns>Feet per second</returns>
        public static double MilesPerHourToFeetPerSecond(double mph)
        {
            return mph * ConstValues.Mphfps;
        }

        /// <summary>
        /// Convert Miles per hour to Meters per second
        /// </summary>
        /// <param name="mph"></param>
        /// <returns>Meters per second</returns>
        public static double MilesPerHourToMetersPerSecond(double mph)
        {
            return mph / ConstValues.Mphmps;
        }

        /// <summary>
        /// Convert Miles per hour to Kilometers per hour
        /// </summary>
        /// <param name="mph"></param>
        /// <returns>Kilometers per hour</returns>
        public static double MilesPerHourToKilometersPerHour(double mph)
        {
            return mph * ConstValues.Mphkph;
        }

        /// <summary>
        /// Convert Miles per hour to Knots
        /// </summary>
        /// <param name="mph"></param>
        /// <returns>Knots</returns>
        public static double MilesPerHourToKnots(double mph)
        {
            return mph / ConstValues.Mphknot;
        }

        /// <summary>
        /// Convert Feet per second to Miles per hour
        /// </summary>
        /// <param name="fps"></param>
        /// <returns>Miles per hour</returns>
        public static double FeetPerSecondToMilesPerHour(double fps)
        {
            return fps / ConstValues.Mphfps;
        }

        /// <summary>
        /// Convert Feet per second to Meters per second
        /// </summary>
        /// <param name="fps"></param>
        /// <returns>Meters per second</returns>
        public static double FeetPerSecondToMetersPerSecond(double fps)
        {
            return fps / ConstValues.Fpsmps;
        }

        /// <summary>
        /// Convert Feet per second to Kilometers per hour
        /// </summary>
        /// <param name="fps"></param>
        /// <returns></returns>
        public static double FeetPerSecondToKilometersPerHour(double fps)
        {
            return fps * ConstValues.Fpskph;
        }

        /// <summary>
        /// Convert Feet per second to Knots
        /// </summary>
        /// <param name="fps"></param>
        /// <returns>Knots</returns>
        public static double FeetPerSecondToKnots(double fps)
        {
            return fps / ConstValues.Fpsknot;
        }

        /// <summary>
        /// Convert Meters per second to Miles per hour
        /// </summary>
        /// <param name="mps"></param>
        /// <returns>Miles per hour</returns>
        public static double MetersPerSecondToMilesPerHour(double mps)
        {
            return mps * ConstValues.Mphmps;
        }

        /// <summary>
        /// Convert Meters per second to Feet per second
        /// </summary>
        /// <param name="mps"></param>
        /// <returns>Feet per second</returns>
        public static double MetersPerSecondToFeetPerSecond(double mps)
        {
            return mps * ConstValues.Fpsmps;
        }

        /// <summary>
        /// Convert Meters per second to Kilometers per hour
        /// </summary>
        /// <param name="mps"></param>
        /// <returns>Kilometers per hour</returns>
        public static double MetersPerSecondToKilometersPerHour(double mps)
        {
            return mps * ConstValues.Mpskph;
        }

        /// <summary>
        /// Convert Meters per second to Knots
        /// </summary>
        /// <param name="mps"></param>
        /// <returns>Knots</returns>
        public static double MetersPerSecondToKnots(double mps)
        {
            return mps * ConstValues.Mpsknot;
        }

        /// <summary>
        /// Convert Kilometers per hour to Miles per hour
        /// </summary>
        /// <param name="kph"></param>
        /// <returns>Miles per hour</returns>
        public static double KilometersPerHourToMilesPerHour(double kph)
        {
            return kph / ConstValues.Mphkph;
        }

        /// <summary>
        /// Convert Kilometers per hour to Feet per second
        /// </summary>
        /// <param name="kph"></param>
        /// <returns></returns>
        public static double KilometersPerHourToFeetPerSecond(double kph)
        {
            return kph / ConstValues.Fpskph;
        }

        /// <summary>
        /// Convert Kilometers per hour to Meters per second
        /// </summary>
        /// <param name="kph"></param>
        /// <returns></returns>
        public static double KilometersPerHourToMetersPerSecond(double kph)
        {
            return kph / ConstValues.Mpskph;
        }

        /// <summary>
        /// Convert Kilometers per hour to Knots
        /// </summary>
        /// <param name="kph"></param>
        /// <returns></returns>
        public static double KilometersPerHourToKnots(double kph)
        {
            return kph / ConstValues.Kphknot;
        }

        /// <summary>
        /// Convert Knots to Kilometers per hour
        /// </summary>
        /// <param name="knots"></param>
        /// <returns>Kilometers per hour</returns>
        public static double KnotsToMilesPerHour(double knots)
        {
            return knots * ConstValues.Mphknot;
        }
        
        /// <summary>
        /// Convert Knots to Feet per second
        /// </summary>
        /// <param name="knots"></param>
        /// <returns>Feet per second</returns>
        public static double KnotsToFeetPerSecond(double knots)
        {
            return knots * ConstValues.Fpsknot;
        }

        /// <summary>
        /// Convert Knots to Meters per second
        /// </summary>
        /// <param name="knots"></param>
        /// <returns>Meters per second</returns>
        public static double KnotsToMetersPerSecond(double knots)
        {
            return knots / ConstValues.Mpsknot;
        }

        /// <summary>
        /// Convert Knots to Kilometers per hour
        /// </summary>
        /// <param name="knots"></param>
        /// <returns></returns>
        public static double KnotsToKilometersPerHour(double knots)
        {
            return knots * ConstValues.Kphknot;
        }
    }
}
