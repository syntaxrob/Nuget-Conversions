﻿using System;

namespace Conversions
{
    public class Length
    {
        /// <summary>
        /// Convert from Kilometers to Meters.
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Meter value</returns>
        public double KilometerToMeter(double kilometer)
        {
            return kilometer * LengthConstValues.km_m;
        }

        /// <summary>
        /// Convert from Meters to Kilometers.
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Kilometer value</returns>
        public double MeterToKilometer(double meter)
        {
            return meter / LengthConstValues.km_m;
        }

        /// <summary>
        /// Convert from Kilometers to Centimeters.
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Centimeter value</returns>
        public double KilometerToCentimeter(double kilometer)
        {
            return kilometer * LengthConstValues.km_cm;
        }

        /// <summary>
        /// Convert Centimeter to Kilometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Kilometer value</returns>
        public double CentimeterToKilometer(double centimeter)
        {
            return centimeter / LengthConstValues.km_cm;
        }

        /// <summary>
        /// Convert Kilometer to Millimeter
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Millimeter value</returns>
        public double KilometerToMilliimeter(double kilometer)
        {
            return kilometer * LengthConstValues.km_mm;
        }

        /// <summary>
        /// Convert Millimeter to Kilometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Kilometer value</returns>
        public double MillimeterToKilometer(double millimeter)
        {
            return millimeter / LengthConstValues.km_mm;
        }

        /// <summary>
        /// Convert Kilometer to micrometer
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Micrometer value</returns>
        public double KilometerToMicrometer(double kilometer)
        {
            return kilometer * LengthConstValues.km_microm;
        }

        /// <summary>
        /// Convert Micrometer to Kilometer
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Kilometer value</returns>
        public double MicrometerToKilometer(double micrometer)
        {
            return micrometer / LengthConstValues.km_microm;
        }

        /// <summary>
        /// Convert Kilometers to Nanometers
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Nanometer value</returns>
        public double KilometerToNanometer(double kilometer)
        {
            return kilometer * LengthConstValues.km_nanom;
        }

        /// <summary>
        /// Convert Nanometers to Kilometers
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Kilometers value</returns>
        public double NanometerToKilometer(double nanometer)
        {
            return nanometer / LengthConstValues.km_nanom;
        }

        /// <summary>
        /// Convert Kilometer to mile
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Mile value</returns>
        public double KilometerToMile(double kilometer)
        {
            return kilometer / LengthConstValues.km_mile;
        }

        /// <summary>
        /// Convert Mile to Kilometer
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Kilometer value</returns>
        public double MileToKilometer(double mile)
        {
            return mile * LengthConstValues.km_mile;
        }

        /// <summary>
        /// Convert Kilometer to Yard
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Yard value</returns>
        public double KilometerToYard(double kilometer)
        {
            return kilometer * LengthConstValues.km_yard;
        }

        /// <summary>
        /// Convert Yard to Kilometer
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Kilometer value</returns>
        public double YardToKilometer(double yard)
        {
            return yard / LengthConstValues.km_yard;
        }

        /// <summary>
        /// Convert Kilometer to Foot
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Foot value</returns>
        public double KilometerToFoot(double kilometer)
        {
            return kilometer * LengthConstValues.km_foot;
        }

        /// <summary>
        /// Convert Foot to Kilometer
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Kilometer value</returns>
        public double FootToKiloMeter(double foot)
        {
            return foot / LengthConstValues.km_foot;
        }

        /// <summary>
        /// Convert Kilometer to Inch
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Inch value</returns>
        public double KilometerToInch(double kilometer)
        {
            return kilometer * LengthConstValues.km_inch;
        }

        /// <summary>
        /// Convert Inch to Kilometer
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Inch value</returns>
        public double InchToKilometer(double kilometer)
        {
            return kilometer / LengthConstValues.km_inch;
        }

        
    }
}
