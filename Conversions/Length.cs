using System;

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

        /// <summary>
        /// Convert Kilometer to Nautical mile
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Nautical mile value</returns>
        public double KilometerToNauticalMile(double kilometer)
        {
            return kilometer / LengthConstValues.km_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Kilometer
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Kilometer value</returns>
        public double NauticalMileToKilometer(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.km_nauticalmile;
        }

        /// <summary>
        /// Convert Meters to Centimeters
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Centimeter values</returns>
        public double MeterToCentimeter(double meter)
        {
            return meter * LengthConstValues.m_cm;
        }

        /// <summary>
        /// Convert Centimeter to Meter
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Meter value</returns>
        public double CentimeterToMeter(double centimeter)
        {
            return centimeter / LengthConstValues.m_cm;
        }

        /// <summary>
        /// Convert Meter to Millimeters
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Millimeter value</returns>
        public double MeterToMillimeter(double meter)
        {
            return meter * LengthConstValues.m_mm;
        }

        /// <summary>
        /// Convert Millimeter to Meter
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Meter value</returns>
        public double MillimeterToMeter(double millimeter)
        {
            return millimeter * LengthConstValues.m_mm;
        }

        /// <summary>
        /// Convert Meter to Micrometer
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Micrometer value</returns>
        public double MeterToMicrometer(double meter)
        {
            return meter * LengthConstValues.m_microm;
        }

        /// <summary>
        /// Convert Micrometer to Meter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Meter value</returns>
        public double MicrometerToMeter(double micrometer)
        {
            return micrometer / LengthConstValues.m_microm;
        }

        /// <summary>
        /// Convert Meter to Nanometer
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Nanometer value</returns>
        public double MeterToNanometer(double meter)
        {
            return meter * LengthConstValues.m_nanom;
        }

        /// <summary>
        /// Convert Nanometer to Meter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Meter value</returns>
        public double NanometerToMeter(double nanometer)
        {
            return nanometer / LengthConstValues.m_nanom;
        }

        /// <summary>
        /// Convert Meter to Mile
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Mile value</returns>
        public double MeterToMile(double meter)
        {
            return meter / LengthConstValues.m_mile;
        }

        /// <summary>
        /// Convert Mile to Meter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Meter value</returns>
        public double MileToMeter(double mile)
        {
            return mile * LengthConstValues.m_mile;
        }

        /// <summary>
        /// Convert Meter to Yard
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Yard value</returns>
        public double MeterToYard(double meter)
        {
            return meter * LengthConstValues.m_yard;
        }

        /// <summary>
        /// Convert Yard To Meter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Meter value</returns>
        public double YardToMeter(double yard)
        {
            return yard / LengthConstValues.m_yard;
        }

        /// <summary>
        /// Convert Meter to Foot
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Foot value</returns>
        public double MeterToFoot(double meter)
        {
            return meter * LengthConstValues.m_foot;
        }

        /// <summary>
        /// Convert Foot to Meter
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Meter value</returns>
        public double FootToMeter(double foot)
        {
            return foot / LengthConstValues.m_foot;
        }

        /// <summary>
        /// Convert Meter to Inch
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Inch value</returns>
        public double MeterToInch(double meter)
        {
            return meter * LengthConstValues.m_inch;
        }

        /// <summary>
        /// Convert Inch to Meter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Meter value</returns>
        public double InchToMeter(double inch)
        {
            return inch / LengthConstValues.m_inch;
        }

        /// <summary>
        /// Convert Meter to Nauticalmile
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Nauticalmile value</returns>
        public double MeterToNauticalmile(double meter)
        {
            return meter / LengthConstValues.m_nauticalmile;
        }

        /// <summary>
        /// Convert Nauticalmile to Meter
        /// </summary>
        /// <param name="nmile"></param>
        /// <returns>Meter value</returns>
        public double NauticalmileToMeter(double nmile)
        {
            return nmile * LengthConstValues.m_nauticalmile;
        }

        /// <summary>
        /// Convert Centimeter to Millimeter
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Millimeter value</returns>
        public double CentimeterToMillimeter(double centimeter)
        {
            return centimeter * LengthConstValues.cm_mm;
        }

        /// <summary>
        /// Convert Millimeter to Centimeter
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Centimeter value</returns>
        public double MillimeterToCentimeter(double millimeter)
        {
            return millimeter / LengthConstValues.cm_mm;
        }

        /// <summary>
        /// Convert Centimeter to Micrometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Micrometer value</returns>
        public double CentimeterToMicrometer(double centimeter)
        {
            return centimeter * LengthConstValues.cm_microm;
        }

        /// <summary>
        /// Convert Micrometer to Centimeter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Centimeter value</returns>
        public double MicrometerToCentimeter(double micrometer)
        {
            return micrometer / LengthConstValues.cm_microm;
        }

        /// <summary>
        /// Convert Centimeter to Nanometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Nanometer value</returns>
        public double CentimeterToNanometer(double centimeter)
        {
            return centimeter * LengthConstValues.cm_nanom;
        }

        /// <summary>
        /// Convert Nanometer to Centimeter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Centimeter value</returns>
        public double NanometerToCentimeter(double nanometer)
        {
            return nanometer / LengthConstValues.cm_nanom;
        }

        /// <summary>
        /// Convert Centimeter to Mile
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Mile value</returns>
        public double CentimeterToMile(double centimeter)
        {
            return centimeter / LengthConstValues.cm_mile;
        }

        /// <summary>
        /// Convert Mile to Centimeter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Centimeter value</returns>
        public double MileToCentimeter(double mile)
        {
            return mile * LengthConstValues.cm_mile;
        }

        /// <summary>
        /// Convert Centimeter to Yard
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Yard value</returns>
        public double CentimeterToYard(double centimeter)
        {
            return centimeter / LengthConstValues.cm_yard;
        }

        /// <summary>
        /// Convert Yard to Centimeter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Centimeter value</returns>
        public double YardToCentimeter(double yard)
        {
            return yard * LengthConstValues.cm_yard;
        }

        /// <summary>
        /// Convert Centimeter to Foot
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Foot value</returns>
        public double CentimeterToFoot(double centimeter)
        {
            return centimeter / LengthConstValues.cm_foot;
        }

        /// <summary>
        /// Convert Foot to Centimeter
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Centimeter value</returns>
        public double FootToCentimeter(double foot)
        {
            return foot * LengthConstValues.cm_foot;
        }

        /// <summary>
        /// Convert Centimeter to Inch
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Inch value</returns>
        public double CentimeterToInch(double centimeter)
        {
            return centimeter / LengthConstValues.cm_inch;
        }

        /// <summary>
        /// Convert Inch to Centimeter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Centimeter value</returns>
        public double InchToCentimeter(double inch)
        {
            return inch * LengthConstValues.cm_inch;
        }

        /// <summary>
        /// Convert Centimeter to Nautical Mile
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Nautical mile value</returns>
        public double CentimeterToNauticalMile(double centimeter)
        {
            return centimeter / LengthConstValues.cm_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Centimeter
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Centimeter value</returns>
        public double NauticalMileToCentimeter(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.cm_nauticalmile;
        }

        /// <summary>
        /// Convert Millimeter to Micrometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Micrometer value</returns>
        public double MillimeterToMicrometer(double millimeter)
        {
            return millimeter * LengthConstValues.mm_microm;
        }

        /// <summary>
        /// Convert Micrometer to Millimeter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Millimeter value</returns>
        public double MicrometerToMillimeter(double micrometer)
        {
            return micrometer / LengthConstValues.mm_microm;
        }

        /// <summary>
        /// Convert Millimeter to Nanometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Nanometer value</returns>
        public double MillimeterToNanometer(double millimeter)
        {
            return millimeter * LengthConstValues.mm_nanom;
        }

        /// <summary>
        /// Convert Nanometer to Millimeter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Millimeter value</returns>
        public double NanometerToMillimeter(double nanometer)
        {
            return nanometer / LengthConstValues.mm_nanom;
        }

        /// <summary>
        /// Convert Millimeter to Mile
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Mile value</returns>
        public double MillimeterToMile(double millimeter)
        {
            return millimeter / LengthConstValues.mm_mile;
        }

        /// <summary>
        /// Convert Mile to Millimeter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Millimeter value</returns>
        public double MileToMillimeter(double mile)
        {
            return mile * LengthConstValues.mm_mile;
        }




    }
}
