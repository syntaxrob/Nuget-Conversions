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
            public const double GradMoa = 54;
            public const double GradSoa = 3240;
            public const double MoaSoa = 60;
            public const double RadMrad = 1000;
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

        /// <summary>
        /// Convert Gradians to Degrees
        /// </summary>
        /// <param name="grad"></param>
        /// <returns>Degrees</returns>
        public static double GradianToDegree(double grad)
        {
            return grad * ConstValues.DegGrad;
        }

        /// <summary>
        /// Converts Gradians to Milliradians
        /// </summary>
        /// <param name="grad"></param>
        /// <returns>Milliradians</returns>
        public static double GradianToMilliradian(double grad)
        {
            return grad * ((1000 * ConstValues.Pi)/200);
        }

        /// <summary>
        /// Converts Gradians to Minutes of Arc
        /// </summary>
        /// <param name="grad"></param>
        /// <returns>Minutes of Arc</returns>
        public static double GradianToMinuteOfArc(double grad)
        {
            return grad * ConstValues.GradMoa;
        }

        /// <summary>
        /// Convert Gradians to Radians
        /// </summary>
        /// <param name="grad"></param>
        /// <returns>Radians</returns>
        public static double GradianToRadian(double grad)
        {
            return grad * (ConstValues.Pi/200);
        }

        /// <summary>
        /// Converts Gradians to Seconds of Arc
        /// </summary>
        /// <param name="grad"></param>
        /// <returns>Seconds of Arc</returns>
        public static double GradianToSecondOfArc(double grad)
        {
            return grad * ConstValues.GradSoa;
        }

        /// <summary>
        /// Convert Milliradians to Degrees
        /// </summary>
        /// <param name="millirads"></param>
        /// <returns>Degrees</returns>
        public static double MilliRadiansToDegrees(double millirads)
        {
            return millirads * (1800/(1000 * ConstValues.Pi));
        }

        /// <summary>
        /// Convert Milliradians to Gradians
        /// </summary>
        /// <param name="millirads"></param>
        /// <returns>Gradians</returns>
        public static double MilliRadiansToGradians(double millirads)
        {
            return millirads * (200 / (1000 * ConstValues.Pi));
        }

        /// <summary>
        /// Convert Milliradians to Minutes of Arc
        /// </summary>
        /// <param name="millirads"></param>
        /// <returns>Minutes of Arc</returns>
        public static double MilliRadiansToMinuteOfArc(double millirads)
        {
            return millirads * (60 * 180) / (1000 * ConstValues.Pi);
        }

        /// <summary>
        /// Convert Milliradians to Radians
        /// </summary>
        /// <param name="millirads"></param>
        /// <returns>Radians</returns>
        public static double MilliRadiansToRadians(double millirads)
        {
            return millirads / 1000;
        }

        /// <summary>
        /// Convert Milliradians to Seconds of Arc
        /// </summary>
        /// <param name="millirads"></param>
        /// <returns></returns>
        public static double MilliRadiansToSecondOfArc(double millirads)
        {
            return millirads * (3600 * 180) / (1000 * ConstValues.Pi);
        }

        /// <summary>
        /// Convert Minutes of Arc to Degrees
        /// </summary>
        /// <param name="moa"></param>
        /// <returns>Degrees</returns>
        public static double MinuteOfArcToDegrees(double moa)
        {
            return moa / ConstValues.DegMoa;
        }

        /// <summary>
        /// Convert Minutes of Arc to Gradians
        /// </summary>
        /// <param name="moa"></param>
        /// <returns>Gradians</returns>
        public static double MinuteOfArcToGradians(double moa)
        {
            return moa / ConstValues.DegGrad;
        }

        /// <summary>
        /// Convert Minutes of Arc to Milliradians
        /// </summary>
        /// <param name="moa"></param>
        /// <returns>Milliradians</returns>
        public static double MinuteOfArcToMilliradians(double moa)
        {
            return moa * (1000 * ConstValues.Pi) / (60 * 180);
        }

        /// <summary>
        /// Convert Minutes of Arc to Radians
        /// </summary>
        /// <param name="moa"></param>
        /// <returns>Radians</returns>
        public static double MinuteOfArcToRadians(double moa)
        {
            return moa * (ConstValues.Pi / (60 * 180));
        }

        /// <summary>
        /// Convert Minutes of Arc to Seconds of Arc
        /// </summary>
        /// <param name="moa"></param>
        /// <returns>Seconds of Arc</returns>
        public static double MinuteOfArcToSecondOfArc(double moa)
        {
            return moa * ConstValues.MoaSoa;
        }

        /// <summary>
        /// Convert Radians to Degrees
        /// </summary>
        /// <param name="rad"></param>
        /// <returns>Degrees</returns>
        public static double RadiansToDegrees(double rad)
        {
            return rad * (180 / ConstValues.Pi);
        }

        /// <summary>
        /// Convert Radians to Gradians
        /// </summary>
        /// <param name="rad"></param>
        /// <returns>Gradians</returns>
        public static double RadiansToGradians(double rad)
        {
            return rad * (200 * ConstValues.Pi);
        }

        /// <summary>
        /// Convert Radians to Milliradians
        /// </summary>
        /// <param name="rad"></param>
        /// <returns>Milliradians</returns>
        public static double RadiansToMilliradians(double rad)
        {
            return rad * ConstValues.RadMrad;
        }

        /// <summary>
        /// Convert Radians to Minutes of Arc
        /// </summary>
        /// <param name="rad"></param>
        /// <returns>Minutes of Arc</returns>
        public static double RadiansToMinuteOfArc(double rad)
        {
            return rad * ((60 * 180) / ConstValues.Pi);
        }

        /// <summary>
        /// Convert Radians to Seconds of Arc
        /// </summary>
        /// <param name="rad"></param>
        /// <returns>Seconds of Arc</returns>
        public static double RadiansToSecondOfArc(double rad)
        {
            return rad * ((3600 * 180) / ConstValues.Pi);
        }
    }
}
