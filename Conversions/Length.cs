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
        public static double KilometerToMeter(double kilometer)
        {
            return kilometer * LengthConstValues.km_m;
        }

        /// <summary>
        /// Convert from Meters to Kilometers.
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Kilometer value</returns>
        public static double MeterToKilometer(double meter)
        {
            return meter / LengthConstValues.km_m;
        }

        /// <summary>
        /// Convert from Kilometers to Centimeters.
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Centimeter value</returns>
        public static double KilometerToCentimeter(double kilometer)
        {
            return kilometer * LengthConstValues.km_cm;
        }

        /// <summary>
        /// Convert Centimeter to Kilometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Kilometer value</returns>
        public static double CentimeterToKilometer(double centimeter)
        {
            return centimeter / LengthConstValues.km_cm;
        }

        /// <summary>
        /// Convert Kilometer to Millimeter
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Millimeter value</returns>
        public static double KilometerToMilliimeter(double kilometer)
        {
            return kilometer * LengthConstValues.km_mm;
        }

        /// <summary>
        /// Convert Millimeter to Kilometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Kilometer value</returns>
        public static double MillimeterToKilometer(double millimeter)
        {
            return millimeter / LengthConstValues.km_mm;
        }

        /// <summary>
        /// Convert Kilometer to micrometer
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Micrometer value</returns>
        public static double KilometerToMicrometer(double kilometer)
        {
            return kilometer * LengthConstValues.km_microm;
        }

        /// <summary>
        /// Convert Micrometer to Kilometer
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Kilometer value</returns>
        public static double MicrometerToKilometer(double micrometer)
        {
            return micrometer / LengthConstValues.km_microm;
        }

        /// <summary>
        /// Convert Kilometers to Nanometers
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Nanometer value</returns>
        public static double KilometerToNanometer(double kilometer)
        {
            return kilometer * LengthConstValues.km_nanom;
        }

        /// <summary>
        /// Convert Nanometers to Kilometers
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Kilometers value</returns>
        public static double NanometerToKilometer(double nanometer)
        {
            return nanometer / LengthConstValues.km_nanom;
        }

        /// <summary>
        /// Convert Kilometer to mile
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Mile value</returns>
        public static double KilometerToMile(double kilometer)
        {
            return kilometer / LengthConstValues.km_mile;
        }

        /// <summary>
        /// Convert Mile to Kilometer
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Kilometer value</returns>
        public static double MileToKilometer(double mile)
        {
            return mile * LengthConstValues.km_mile;
        }

        /// <summary>
        /// Convert Kilometer to Yard
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Yard value</returns>
        public static double KilometerToYard(double kilometer)
        {
            return kilometer * LengthConstValues.km_yard;
        }

        /// <summary>
        /// Convert Yard to Kilometer
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Kilometer value</returns>
        public static double YardToKilometer(double yard)
        {
            return yard / LengthConstValues.km_yard;
        }

        /// <summary>
        /// Convert Kilometer to Foot
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Foot value</returns>
        public static double KilometerToFoot(double kilometer)
        {
            return kilometer * LengthConstValues.km_foot;
        }

        /// <summary>
        /// Convert Foot to Kilometer
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Kilometer value</returns>
        public static double FootToKiloMeter(double foot)
        {
            return foot / LengthConstValues.km_foot;
        }

        /// <summary>
        /// Convert Kilometer to Inch
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Inch value</returns>
        public static double KilometerToInch(double kilometer)
        {
            return kilometer * LengthConstValues.km_inch;
        }

        /// <summary>
        /// Convert Inch to Kilometer
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Inch value</returns>
        public static double InchToKilometer(double kilometer)
        {
            return kilometer / LengthConstValues.km_inch;
        }

        /// <summary>
        /// Convert Kilometer to Nautical mile
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Nautical mile value</returns>
        public static double KilometerToNauticalMile(double kilometer)
        {
            return kilometer / LengthConstValues.km_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Kilometer
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Kilometer value</returns>
        public static double NauticalMileToKilometer(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.km_nauticalmile;
        }

        /// <summary>
        /// Convert Meters to Centimeters
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Centimeter values</returns>
        public static double MeterToCentimeter(double meter)
        {
            return meter * LengthConstValues.m_cm;
        }

        /// <summary>
        /// Convert Centimeter to Meter
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Meter value</returns>
        public static double CentimeterToMeter(double centimeter)
        {
            return centimeter / LengthConstValues.m_cm;
        }

        /// <summary>
        /// Convert Meter to Millimeters
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Millimeter value</returns>
        public static double MeterToMillimeter(double meter)
        {
            return meter * LengthConstValues.m_mm;
        }

        /// <summary>
        /// Convert Millimeter to Meter
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Meter value</returns>
        public static double MillimeterToMeter(double millimeter)
        {
            return millimeter * LengthConstValues.m_mm;
        }

        /// <summary>
        /// Convert Meter to Micrometer
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Micrometer value</returns>
        public static double MeterToMicrometer(double meter)
        {
            return meter * LengthConstValues.m_microm;
        }

        /// <summary>
        /// Convert Micrometer to Meter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Meter value</returns>
        public static double MicrometerToMeter(double micrometer)
        {
            return micrometer / LengthConstValues.m_microm;
        }

        /// <summary>
        /// Convert Meter to Nanometer
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Nanometer value</returns>
        public static double MeterToNanometer(double meter)
        {
            return meter * LengthConstValues.m_nanom;
        }

        /// <summary>
        /// Convert Nanometer to Meter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Meter value</returns>
        public static double NanometerToMeter(double nanometer)
        {
            return nanometer / LengthConstValues.m_nanom;
        }

        /// <summary>
        /// Convert Meter to Mile
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Mile value</returns>
        public static double MeterToMile(double meter)
        {
            return meter / LengthConstValues.m_mile;
        }

        /// <summary>
        /// Convert Mile to Meter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Meter value</returns>
        public static double MileToMeter(double mile)
        {
            return mile * LengthConstValues.m_mile;
        }

        /// <summary>
        /// Convert Meter to Yard
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Yard value</returns>
        public static double MeterToYard(double meter)
        {
            return meter * LengthConstValues.m_yard;
        }

        /// <summary>
        /// Convert Yard To Meter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Meter value</returns>
        public static double YardToMeter(double yard)
        {
            return yard / LengthConstValues.m_yard;
        }

        /// <summary>
        /// Convert Meter to Foot
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Foot value</returns>
        public static double MeterToFoot(double meter)
        {
            return meter * LengthConstValues.m_foot;
        }

        /// <summary>
        /// Convert Foot to Meter
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Meter value</returns>
        public static double FootToMeter(double foot)
        {
            return foot / LengthConstValues.m_foot;
        }

        /// <summary>
        /// Convert Meter to Inch
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Inch value</returns>
        public static double MeterToInch(double meter)
        {
            return meter * LengthConstValues.m_inch;
        }

        /// <summary>
        /// Convert Inch to Meter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Meter value</returns>
        public static double InchToMeter(double inch)
        {
            return inch / LengthConstValues.m_inch;
        }

        /// <summary>
        /// Convert Meter to Nauticalmile
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Nauticalmile value</returns>
        public static double MeterToNauticalmile(double meter)
        {
            return meter / LengthConstValues.m_nauticalmile;
        }

        /// <summary>
        /// Convert Nauticalmile to Meter
        /// </summary>
        /// <param name="nmile"></param>
        /// <returns>Meter value</returns>
        public static double NauticalmileToMeter(double nmile)
        {
            return nmile * LengthConstValues.m_nauticalmile;
        }

        /// <summary>
        /// Convert Centimeter to Millimeter
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Millimeter value</returns>
        public static double CentimeterToMillimeter(double centimeter)
        {
            return centimeter * LengthConstValues.cm_mm;
        }

        /// <summary>
        /// Convert Millimeter to Centimeter
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Centimeter value</returns>
        public static double MillimeterToCentimeter(double millimeter)
        {
            return millimeter / LengthConstValues.cm_mm;
        }

        /// <summary>
        /// Convert Centimeter to Micrometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Micrometer value</returns>
        public static double CentimeterToMicrometer(double centimeter)
        {
            return centimeter * LengthConstValues.cm_microm;
        }

        /// <summary>
        /// Convert Micrometer to Centimeter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Centimeter value</returns>
        public static double MicrometerToCentimeter(double micrometer)
        {
            return micrometer / LengthConstValues.cm_microm;
        }

        /// <summary>
        /// Convert Centimeter to Nanometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Nanometer value</returns>
        public static double CentimeterToNanometer(double centimeter)
        {
            return centimeter * LengthConstValues.cm_nanom;
        }

        /// <summary>
        /// Convert Nanometer to Centimeter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Centimeter value</returns>
        public static double NanometerToCentimeter(double nanometer)
        {
            return nanometer / LengthConstValues.cm_nanom;
        }

        /// <summary>
        /// Convert Centimeter to Mile
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Mile value</returns>
        public static double CentimeterToMile(double centimeter)
        {
            return centimeter / LengthConstValues.cm_mile;
        }

        /// <summary>
        /// Convert Mile to Centimeter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Centimeter value</returns>
        public static double MileToCentimeter(double mile)
        {
            return mile * LengthConstValues.cm_mile;
        }

        /// <summary>
        /// Convert Centimeter to Yard
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Yard value</returns>
        public static double CentimeterToYard(double centimeter)
        {
            return centimeter / LengthConstValues.cm_yard;
        }

        /// <summary>
        /// Convert Yard to Centimeter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Centimeter value</returns>
        public static double YardToCentimeter(double yard)
        {
            return yard * LengthConstValues.cm_yard;
        }

        /// <summary>
        /// Convert Centimeter to Foot
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Foot value</returns>
        public static double CentimeterToFoot(double centimeter)
        {
            return centimeter / LengthConstValues.cm_foot;
        }

        /// <summary>
        /// Convert Foot to Centimeter
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Centimeter value</returns>
        public static double FootToCentimeter(double foot)
        {
            return foot * LengthConstValues.cm_foot;
        }

        /// <summary>
        /// Convert Centimeter to Inch
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Inch value</returns>
        public static double CentimeterToInch(double centimeter)
        {
            return centimeter / LengthConstValues.cm_inch;
        }

        /// <summary>
        /// Convert Inch to Centimeter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Centimeter value</returns>
        public static double InchToCentimeter(double inch)
        {
            return inch * LengthConstValues.cm_inch;
        }

        /// <summary>
        /// Convert Centimeter to Nautical Mile
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Nautical mile value</returns>
        public static double CentimeterToNauticalMile(double centimeter)
        {
            return centimeter / LengthConstValues.cm_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Centimeter
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Centimeter value</returns>
        public static double NauticalMileToCentimeter(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.cm_nauticalmile;
        }

        /// <summary>
        /// Convert Millimeter to Micrometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Micrometer value</returns>
        public static double MillimeterToMicrometer(double millimeter)
        {
            return millimeter * LengthConstValues.mm_microm;
        }

        /// <summary>
        /// Convert Micrometer to Millimeter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Millimeter value</returns>
        public static double MicrometerToMillimeter(double micrometer)
        {
            return micrometer / LengthConstValues.mm_microm;
        }

        /// <summary>
        /// Convert Millimeter to Nanometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Nanometer value</returns>
        public static double MillimeterToNanometer(double millimeter)
        {
            return millimeter * LengthConstValues.mm_nanom;
        }

        /// <summary>
        /// Convert Nanometer to Millimeter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Millimeter value</returns>
        public static double NanometerToMillimeter(double nanometer)
        {
            return nanometer / LengthConstValues.mm_nanom;
        }

        /// <summary>
        /// Convert Millimeter to Mile
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Mile value</returns>
        public static double MillimeterToMile(double millimeter)
        {
            return millimeter / LengthConstValues.mm_mile;
        }

        /// <summary>
        /// Convert Mile to Millimeter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Millimeter value</returns>
        public static double MileToMillimeter(double mile)
        {
            return mile * LengthConstValues.mm_mile;
        }

        /// <summary>
        /// Convert Millimeter to Yard
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Yard value</returns>
        public static double MillimeterToYard(double millimeter)
        {
            return millimeter / LengthConstValues.mm_yard;
        }

        /// <summary>
        /// Convert Yard to Millimeter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Millimeter value</returns>
        public static double YardToMillimeter(double yard)
        {
            return yard * LengthConstValues.mm_yard;
        }

        /// <summary>
        /// Convert Millimeter to Foot
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Foot value</returns>
        public static double MillimeterToFoot(double millimeter)
        {
            return millimeter / LengthConstValues.mm_foot;
        }

        /// <summary>
        /// Convert Foot to Millimeter
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Millimeter value</returns>
        public static double FootToMillimeter(double foot)
        {
            return foot * LengthConstValues.mm_foot;
        }

        /// <summary>
        /// Convert Millimeter to Inch
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Inch value</returns>
        public static double MillimeterToInch(double millimeter)
        {
            return millimeter / LengthConstValues.mm_inch;
        }

        /// <summary>
        /// Convert Inch to Millimeter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Millimeter value</returns>
        public static double InchToMillimeter(double inch)
        {
            return inch * LengthConstValues.mm_inch;
        }

        /// <summary>
        /// Convert Millimeter to Nautical Mile
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Nautical Mile value</returns>
        public static double MillimeterToNauticalmile(double millimeter)
        {
            return millimeter / LengthConstValues.mm_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical Mile to Millimeter
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Millimeter value</returns>
        public static double NauticalmileToMillimeter(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.mm_nauticalmile;
        }

        /// <summary>
        /// Convert Micrometer to Nanometer
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Nanometer to Micrometer</returns>
        public static double MicrometerToNanometer(double micrometer)
        {
            return micrometer * LengthConstValues.micro_nanom;
        }

        /// <summary>
        /// Convert Nanometer to Micrometer
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Micrometer value</returns>
        public static double NanometerToMicrometer(double nanometer)
        {
            return nanometer / LengthConstValues.micro_nanom;
        }

        /// <summary>
        /// Convert Micrometer to Mile
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Mile value</returns>
        public static double MicrometerToMile(double micrometer)
        {
            return micrometer / LengthConstValues.micro_mile;
        }

        /// <summary>
        /// Convert Mile to Micrometer
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Micrometers value</returns>
        public static double MileToMicrometer(double mile)
        {
            return mile * LengthConstValues.micro_mile;
        }

        /// <summary>
        /// Convert Micrometer to Yard
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Yard value</returns>
        public static double MicrometerToYard(double micrometer)
        {
            return micrometer / LengthConstValues.micro_yard;
        }

        /// <summary>
        /// Convert Yard to Micrometer
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Micrometer value</returns>
        public static double YardToMicrometer(double yard)
        {
            return yard * LengthConstValues.micro_yard;
        }

        /// <summary>
        /// Convert Micrometer to Foot
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Foot value</returns>
        public static double MicrometerToFoot(double micrometer)
        {
            return micrometer / LengthConstValues.micro_foot;
        }

        /// <summary>
        /// Convert Foot to Micrometer
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Micrometer value</returns>
        public static double FootToMicrometer(double foot)
        {
            return foot * LengthConstValues.micro_foot;
        }

        /// <summary>
        /// Convert Micrometer to Inch
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Inch value</returns>
        public static double MicrometerToInch(double micrometer)
        {
            return micrometer / LengthConstValues.micro_inch;
        }

        /// <summary>
        /// Convert Inch to Micrometer
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Micrometer value</returns>
        public static double InchToMicrometer(double inch)
        {
            return inch * LengthConstValues.micro_inch;
        }

        /// <summary>
        /// Convert Micrometer to Nautical Mile
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Nautical mile value</returns>
        public static double MicrometerToNauticalmile(double micrometer)
        {
            return micrometer / LengthConstValues.micro_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical Mile to Micrometer
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Micrometer value</returns>
        public static double NauticalmileToMicrometer(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.micro_nauticalmile;
        }

        /// <summary>
        /// Convert Nanometer to Mile
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Mile value</returns>
        public static double NanometerToMile(double nanometer)
        {
            return nanometer / LengthConstValues.nano_mile;
        }

        /// <summary>
        /// Convert Mile to Nanometer
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Nanometer value</returns>
        public static double MileToNanometer(double mile)
        {
            return mile * LengthConstValues.nano_mile;
        }

        /// <summary>
        /// Convert Nanometer to Yard
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Yard value</returns>
        public static double NanometerToYard(double nanometer)
        {
            return nanometer / LengthConstValues.nano_yard;
        }

        /// <summary>
        /// Convert Yard to Nanometer
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Nanometer value</returns>
        public static double YardToNanometer(double yard)
        {
            return yard * LengthConstValues.nano_yard;
        }

        /// <summary>
        /// Convert Nanometer to Foot
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Foot value</returns>
        public static double NanometerToFoot(double nanometer)
        {
            return nanometer / LengthConstValues.nano_foot;
        }

        /// <summary>
        /// Convert Foot to Nanometer
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Nanometer value</returns>
        public static double FootToNanometer(double foot)
        {
            return foot * LengthConstValues.nano_foot;
        }

        /// <summary>
        /// Convert Nanometer to Inch
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Inch value</returns>
        public static double NanometerToInch(double nanometer)
        {
            return nanometer / LengthConstValues.nano_inch;
        }

        /// <summary>
        /// Convert Inch to Nanometer
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Nanometer value</returns>
        public static double InchToNanometer(double inch)
        {
            return inch * LengthConstValues.nano_inch;
        }

        /// <summary>
        /// Convert Nanometer to Nautical Mile
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Nautical mile value</returns>
        public static double NanometerToNauticalMile(double nanometer)
        {
            return nanometer / LengthConstValues.nano_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical Mile to Nanometer
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Nanometer value</returns>
        public static double NauticalmileToNanometer(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.nano_nauticalmile;
        }

        /// <summary>
        /// Convert Mile to Yard
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Yard value</returns>
        public static double MileToYard(double mile)
        {
            return mile * LengthConstValues.mile_yard;
        }

        /// <summary>
        /// Convert Yard to Mile
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Mile value</returns>
        public static double YardToMile(double yard)
        {
            return yard / LengthConstValues.mile_yard;
        }

        /// <summary>
        /// Convert Mile to Foot
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Foot value</returns>
        public static double MileToFoot(double mile)
        {
            return mile * LengthConstValues.mile_foot;
        }

        /// <summary>
        /// Convert Foot to Mile
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Mile value</returns>
        public static double FootToMile(double foot)
        {
            return foot / LengthConstValues.mile_foot;
        }

        /// <summary>
        /// Convert Mile to Inch
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Inch value</returns>
        public static double MileToInch(double mile)
        {
            return mile * LengthConstValues.mile_inch;
        }

        /// <summary>
        /// Convert Inch to Mile
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Mile Value</returns>
        public static double InchToMile(double inch)
        {
            return inch / LengthConstValues.mile_inch;
        }

        /// <summary>
        /// Convert Mile to Nautical mile
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Nautical mile value</returns>
        public static double MileToNauticalmile(double mile)
        {
            return mile / LengthConstValues.mile_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Mile
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Mile value</returns>
        public static double NauticalmiletoMile(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.mile_nauticalmile;
        }

        /// <summary>
        /// Convert Yard to Foot
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Foot value</returns>
        public static double YardToFoot(double yard)
        {
            return yard * LengthConstValues.yard_foot;
        }

        /// <summary>
        /// Convert Foot to Yard
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Yard value</returns>
        public static double FootToYard(double foot)
        {
            return foot / LengthConstValues.yard_foot;
        }

        /// <summary>
        /// Convert Yard to Inch
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Inch value</returns>
        public static double YardtoInch(double yard)
        {
            return yard * LengthConstValues.yard_inch;
        }

        /// <summary>
        /// Convert Inch to Yard
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Yard value</returns>
        public static double InchToYard(double inch)
        {
            return inch / LengthConstValues.yard_inch;
        }

        /// <summary>
        /// Convert Yard to Nautical mile
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Nautical mile value</returns>
        public static double YardToNauticalmile(double yard)
        {
            return yard / LengthConstValues.yard_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Yard
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Yard value</returns>
        public static double NauticalmileToYard(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.yard_nauticalmile;
        }

        /// <summary>
        /// Convert Foot to Inch
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Inch value</returns>
        public static double FootToInch(double foot)
        {
            return foot * LengthConstValues.feet_inch;
        }

        /// <summary>
        /// Convert Inch to Foot
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Foot value</returns>
        public static double InchToFoot(double inch)
        {
            return inch / LengthConstValues.feet_inch;
        }

        /// <summary>
        /// Convert Foot to Nautical mile
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Nautical mile value</returns>
        public static double FootToNauticalmile(double foot)
        {
            return foot / LengthConstValues.feet_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to foot
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Foot value</returns>
        public static double NauticalmileToFoot(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.feet_nauticalmile;
        }

        /// <summary>
        /// Convert Inch to Nautical mile
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Nautical mile value</returns>
        public static double InchToNauticalmile(double inch)
        {
            return inch / LengthConstValues.inch_nauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Inch
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Inch value</returns>
        public static double NauticalmileToInch(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.inch_nauticalmile;
        }



    }
}
