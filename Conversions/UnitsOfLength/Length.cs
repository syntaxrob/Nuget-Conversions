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
            return kilometer * LengthConstValues.KmM;
        }

        /// <summary>
        /// Convert from Meters to Kilometers.
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Kilometer value</returns>
        public static double MeterToKilometer(double meter)
        {
            return meter / LengthConstValues.KmM;
        }

        /// <summary>
        /// Convert from Kilometers to Centimeters.
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Centimeter value</returns>
        public static double KilometerToCentimeter(double kilometer)
        {
            return kilometer * LengthConstValues.KmCm;
        }

        /// <summary>
        /// Convert Centimeter to Kilometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Kilometer value</returns>
        public static double CentimeterToKilometer(double centimeter)
        {
            return centimeter / LengthConstValues.KmCm;
        }

        /// <summary>
        /// Convert Kilometer to Millimeter
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Millimeter value</returns>
        public static double KilometerToMilliimeter(double kilometer)
        {
            return kilometer * LengthConstValues.KmMm;
        }

        /// <summary>
        /// Convert Millimeter to Kilometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Kilometer value</returns>
        public static double MillimeterToKilometer(double millimeter)
        {
            return millimeter / LengthConstValues.KmMm;
        }

        /// <summary>
        /// Convert Kilometer to micrometer
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Micrometer value</returns>
        public static double KilometerToMicrometer(double kilometer)
        {
            return kilometer * LengthConstValues.KmMicrom;
        }

        /// <summary>
        /// Convert Micrometer to Kilometer
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Kilometer value</returns>
        public static double MicrometerToKilometer(double micrometer)
        {
            return micrometer / LengthConstValues.KmMicrom;
        }

        /// <summary>
        /// Convert Kilometers to Nanometers
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Nanometer value</returns>
        public static double KilometerToNanometer(double kilometer)
        {
            return kilometer * LengthConstValues.KmNanom;
        }

        /// <summary>
        /// Convert Nanometers to Kilometers
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Kilometers value</returns>
        public static double NanometerToKilometer(double nanometer)
        {
            return nanometer / LengthConstValues.KmNanom;
        }

        /// <summary>
        /// Convert Kilometer to mile
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Mile value</returns>
        public static double KilometerToMile(double kilometer)
        {
            return kilometer / LengthConstValues.KmMile;
        }

        /// <summary>
        /// Convert Mile to Kilometer
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Kilometer value</returns>
        public static double MileToKilometer(double mile)
        {
            return mile * LengthConstValues.KmMile;
        }

        /// <summary>
        /// Convert Kilometer to Yard
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Yard value</returns>
        public static double KilometerToYard(double kilometer)
        {
            return kilometer * LengthConstValues.KmYard;
        }

        /// <summary>
        /// Convert Yard to Kilometer
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Kilometer value</returns>
        public static double YardToKilometer(double yard)
        {
            return yard / LengthConstValues.KmYard;
        }

        /// <summary>
        /// Convert Kilometer to Foot
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Foot value</returns>
        public static double KilometerToFoot(double kilometer)
        {
            return kilometer * LengthConstValues.KmFoot;
        }

        /// <summary>
        /// Convert Foot to Kilometer
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Kilometer value</returns>
        public static double FootToKiloMeter(double foot)
        {
            return foot / LengthConstValues.KmFoot;
        }

        /// <summary>
        /// Convert Kilometer to Inch
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Inch value</returns>
        public static double KilometerToInch(double kilometer)
        {
            return kilometer * LengthConstValues.KmInch;
        }

        /// <summary>
        /// Convert Inch to Kilometer
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Inch value</returns>
        public static double InchToKilometer(double kilometer)
        {
            return kilometer / LengthConstValues.KmInch;
        }

        /// <summary>
        /// Convert Kilometer to Nautical mile
        /// </summary>
        /// <param name="kilometer"></param>
        /// <returns>Nautical mile value</returns>
        public static double KilometerToNauticalMile(double kilometer)
        {
            return kilometer / LengthConstValues.KmNauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Kilometer
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Kilometer value</returns>
        public static double NauticalMileToKilometer(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.KmNauticalmile;
        }

        /// <summary>
        /// Convert Meters to Centimeters
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Centimeter values</returns>
        public static double MeterToCentimeter(double meter)
        {
            return meter * LengthConstValues.MCm;
        }

        /// <summary>
        /// Convert Centimeter to Meter
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Meter value</returns>
        public static double CentimeterToMeter(double centimeter)
        {
            return centimeter / LengthConstValues.MCm;
        }

        /// <summary>
        /// Convert Meter to Millimeters
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Millimeter value</returns>
        public static double MeterToMillimeter(double meter)
        {
            return meter * LengthConstValues.MMm;
        }

        /// <summary>
        /// Convert Millimeter to Meter
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Meter value</returns>
        public static double MillimeterToMeter(double millimeter)
        {
            return millimeter * LengthConstValues.MMm;
        }

        /// <summary>
        /// Convert Meter to Micrometer
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Micrometer value</returns>
        public static double MeterToMicrometer(double meter)
        {
            return meter * LengthConstValues.MMicrom;
        }

        /// <summary>
        /// Convert Micrometer to Meter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Meter value</returns>
        public static double MicrometerToMeter(double micrometer)
        {
            return micrometer / LengthConstValues.MMicrom;
        }

        /// <summary>
        /// Convert Meter to Nanometer
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Nanometer value</returns>
        public static double MeterToNanometer(double meter)
        {
            return meter * LengthConstValues.MNanom;
        }

        /// <summary>
        /// Convert Nanometer to Meter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Meter value</returns>
        public static double NanometerToMeter(double nanometer)
        {
            return nanometer / LengthConstValues.MNanom;
        }

        /// <summary>
        /// Convert Meter to Mile
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Mile value</returns>
        public static double MeterToMile(double meter)
        {
            return meter / LengthConstValues.MMile;
        }

        /// <summary>
        /// Convert Mile to Meter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Meter value</returns>
        public static double MileToMeter(double mile)
        {
            return mile * LengthConstValues.MMile;
        }

        /// <summary>
        /// Convert Meter to Yard
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Yard value</returns>
        public static double MeterToYard(double meter)
        {
            return meter * LengthConstValues.MYard;
        }

        /// <summary>
        /// Convert Yard To Meter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Meter value</returns>
        public static double YardToMeter(double yard)
        {
            return yard / LengthConstValues.MYard;
        }

        /// <summary>
        /// Convert Meter to Foot
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Foot value</returns>
        public static double MeterToFoot(double meter)
        {
            return meter * LengthConstValues.MFoot;
        }

        /// <summary>
        /// Convert Foot to Meter
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Meter value</returns>
        public static double FootToMeter(double foot)
        {
            return foot / LengthConstValues.MFoot;
        }

        /// <summary>
        /// Convert Meter to Inch
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Inch value</returns>
        public static double MeterToInch(double meter)
        {
            return meter * LengthConstValues.MInch;
        }

        /// <summary>
        /// Convert Inch to Meter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Meter value</returns>
        public static double InchToMeter(double inch)
        {
            return inch / LengthConstValues.MInch;
        }

        /// <summary>
        /// Convert Meter to Nauticalmile
        /// </summary>
        /// <param name="meter"></param>
        /// <returns>Nauticalmile value</returns>
        public static double MeterToNauticalmile(double meter)
        {
            return meter / LengthConstValues.MNauticalmile;
        }

        /// <summary>
        /// Convert Nauticalmile to Meter
        /// </summary>
        /// <param name="nmile"></param>
        /// <returns>Meter value</returns>
        public static double NauticalmileToMeter(double nmile)
        {
            return nmile * LengthConstValues.MNauticalmile;
        }

        /// <summary>
        /// Convert Centimeter to Millimeter
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Millimeter value</returns>
        public static double CentimeterToMillimeter(double centimeter)
        {
            return centimeter * LengthConstValues.CmMm;
        }

        /// <summary>
        /// Convert Millimeter to Centimeter
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Centimeter value</returns>
        public static double MillimeterToCentimeter(double millimeter)
        {
            return millimeter / LengthConstValues.CmMm;
        }

        /// <summary>
        /// Convert Centimeter to Micrometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Micrometer value</returns>
        public static double CentimeterToMicrometer(double centimeter)
        {
            return centimeter * LengthConstValues.CmMicrom;
        }

        /// <summary>
        /// Convert Micrometer to Centimeter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Centimeter value</returns>
        public static double MicrometerToCentimeter(double micrometer)
        {
            return micrometer / LengthConstValues.CmMicrom;
        }

        /// <summary>
        /// Convert Centimeter to Nanometer
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Nanometer value</returns>
        public static double CentimeterToNanometer(double centimeter)
        {
            return centimeter * LengthConstValues.CmNanom;
        }

        /// <summary>
        /// Convert Nanometer to Centimeter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Centimeter value</returns>
        public static double NanometerToCentimeter(double nanometer)
        {
            return nanometer / LengthConstValues.CmNanom;
        }

        /// <summary>
        /// Convert Centimeter to Mile
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Mile value</returns>
        public static double CentimeterToMile(double centimeter)
        {
            return centimeter / LengthConstValues.CmMile;
        }

        /// <summary>
        /// Convert Mile to Centimeter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Centimeter value</returns>
        public static double MileToCentimeter(double mile)
        {
            return mile * LengthConstValues.CmMile;
        }

        /// <summary>
        /// Convert Centimeter to Yard
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Yard value</returns>
        public static double CentimeterToYard(double centimeter)
        {
            return centimeter / LengthConstValues.CmYard;
        }

        /// <summary>
        /// Convert Yard to Centimeter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Centimeter value</returns>
        public static double YardToCentimeter(double yard)
        {
            return yard * LengthConstValues.CmYard;
        }

        /// <summary>
        /// Convert Centimeter to Foot
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Foot value</returns>
        public static double CentimeterToFoot(double centimeter)
        {
            return centimeter / LengthConstValues.CmFoot;
        }

        /// <summary>
        /// Convert Foot to Centimeter
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Centimeter value</returns>
        public static double FootToCentimeter(double foot)
        {
            return foot * LengthConstValues.CmFoot;
        }

        /// <summary>
        /// Convert Centimeter to Inch
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Inch value</returns>
        public static double CentimeterToInch(double centimeter)
        {
            return centimeter / LengthConstValues.CmInch;
        }

        /// <summary>
        /// Convert Inch to Centimeter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Centimeter value</returns>
        public static double InchToCentimeter(double inch)
        {
            return inch * LengthConstValues.CmInch;
        }

        /// <summary>
        /// Convert Centimeter to Nautical Mile
        /// </summary>
        /// <param name="centimeter"></param>
        /// <returns>Nautical mile value</returns>
        public static double CentimeterToNauticalMile(double centimeter)
        {
            return centimeter / LengthConstValues.CmNauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Centimeter
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Centimeter value</returns>
        public static double NauticalMileToCentimeter(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.CmNauticalmile;
        }

        /// <summary>
        /// Convert Millimeter to Micrometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Micrometer value</returns>
        public static double MillimeterToMicrometer(double millimeter)
        {
            return millimeter * LengthConstValues.MmMicrom;
        }

        /// <summary>
        /// Convert Micrometer to Millimeter
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Millimeter value</returns>
        public static double MicrometerToMillimeter(double micrometer)
        {
            return micrometer / LengthConstValues.MmMicrom;
        }

        /// <summary>
        /// Convert Millimeter to Nanometer
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Nanometer value</returns>
        public static double MillimeterToNanometer(double millimeter)
        {
            return millimeter * LengthConstValues.MmNanom;
        }

        /// <summary>
        /// Convert Nanometer to Millimeter
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Millimeter value</returns>
        public static double NanometerToMillimeter(double nanometer)
        {
            return nanometer / LengthConstValues.MmNanom;
        }

        /// <summary>
        /// Convert Millimeter to Mile
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Mile value</returns>
        public static double MillimeterToMile(double millimeter)
        {
            return millimeter / LengthConstValues.MmMile;
        }

        /// <summary>
        /// Convert Mile to Millimeter
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Millimeter value</returns>
        public static double MileToMillimeter(double mile)
        {
            return mile * LengthConstValues.MmMile;
        }

        /// <summary>
        /// Convert Millimeter to Yard
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Yard value</returns>
        public static double MillimeterToYard(double millimeter)
        {
            return millimeter / LengthConstValues.MmYard;
        }

        /// <summary>
        /// Convert Yard to Millimeter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Millimeter value</returns>
        public static double YardToMillimeter(double yard)
        {
            return yard * LengthConstValues.MmYard;
        }

        /// <summary>
        /// Convert Millimeter to Foot
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Foot value</returns>
        public static double MillimeterToFoot(double millimeter)
        {
            return millimeter / LengthConstValues.MmFoot;
        }

        /// <summary>
        /// Convert Foot to Millimeter
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Millimeter value</returns>
        public static double FootToMillimeter(double foot)
        {
            return foot * LengthConstValues.MmFoot;
        }

        /// <summary>
        /// Convert Millimeter to Inch
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Inch value</returns>
        public static double MillimeterToInch(double millimeter)
        {
            return millimeter / LengthConstValues.MmInch;
        }

        /// <summary>
        /// Convert Inch to Millimeter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Millimeter value</returns>
        public static double InchToMillimeter(double inch)
        {
            return inch * LengthConstValues.MmInch;
        }

        /// <summary>
        /// Convert Millimeter to Nautical Mile
        /// </summary>
        /// <param name="millimeter"></param>
        /// <returns>Nautical Mile value</returns>
        public static double MillimeterToNauticalmile(double millimeter)
        {
            return millimeter / LengthConstValues.MmNauticalmile;
        }

        /// <summary>
        /// Convert Nautical Mile to Millimeter
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Millimeter value</returns>
        public static double NauticalmileToMillimeter(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.MmNauticalmile;
        }

        /// <summary>
        /// Convert Micrometer to Nanometer
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Nanometer to Micrometer</returns>
        public static double MicrometerToNanometer(double micrometer)
        {
            return micrometer * LengthConstValues.MicroNanom;
        }

        /// <summary>
        /// Convert Nanometer to Micrometer
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Micrometer value</returns>
        public static double NanometerToMicrometer(double nanometer)
        {
            return nanometer / LengthConstValues.MicroNanom;
        }

        /// <summary>
        /// Convert Micrometer to Mile
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Mile value</returns>
        public static double MicrometerToMile(double micrometer)
        {
            return micrometer / LengthConstValues.MicroMile;
        }

        /// <summary>
        /// Convert Mile to Micrometer
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Micrometers value</returns>
        public static double MileToMicrometer(double mile)
        {
            return mile * LengthConstValues.MicroMile;
        }

        /// <summary>
        /// Convert Micrometer to Yard
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Yard value</returns>
        public static double MicrometerToYard(double micrometer)
        {
            return micrometer / LengthConstValues.MicroYard;
        }

        /// <summary>
        /// Convert Yard to Micrometer
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Micrometer value</returns>
        public static double YardToMicrometer(double yard)
        {
            return yard * LengthConstValues.MicroYard;
        }

        /// <summary>
        /// Convert Micrometer to Foot
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Foot value</returns>
        public static double MicrometerToFoot(double micrometer)
        {
            return micrometer / LengthConstValues.MicroFoot;
        }

        /// <summary>
        /// Convert Foot to Micrometer
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Micrometer value</returns>
        public static double FootToMicrometer(double foot)
        {
            return foot * LengthConstValues.MicroFoot;
        }

        /// <summary>
        /// Convert Micrometer to Inch
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Inch value</returns>
        public static double MicrometerToInch(double micrometer)
        {
            return micrometer / LengthConstValues.MicroInch;
        }

        /// <summary>
        /// Convert Inch to Micrometer
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Micrometer value</returns>
        public static double InchToMicrometer(double inch)
        {
            return inch * LengthConstValues.MicroInch;
        }

        /// <summary>
        /// Convert Micrometer to Nautical Mile
        /// </summary>
        /// <param name="micrometer"></param>
        /// <returns>Nautical mile value</returns>
        public static double MicrometerToNauticalmile(double micrometer)
        {
            return micrometer / LengthConstValues.MicroNauticalmile;
        }

        /// <summary>
        /// Convert Nautical Mile to Micrometer
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Micrometer value</returns>
        public static double NauticalmileToMicrometer(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.MicroNauticalmile;
        }

        /// <summary>
        /// Convert Nanometer to Mile
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Mile value</returns>
        public static double NanometerToMile(double nanometer)
        {
            return nanometer / LengthConstValues.NanoMile;
        }

        /// <summary>
        /// Convert Mile to Nanometer
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Nanometer value</returns>
        public static double MileToNanometer(double mile)
        {
            return mile * LengthConstValues.NanoMile;
        }

        /// <summary>
        /// Convert Nanometer to Yard
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Yard value</returns>
        public static double NanometerToYard(double nanometer)
        {
            return nanometer / LengthConstValues.NanoYard;
        }

        /// <summary>
        /// Convert Yard to Nanometer
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Nanometer value</returns>
        public static double YardToNanometer(double yard)
        {
            return yard * LengthConstValues.NanoYard;
        }

        /// <summary>
        /// Convert Nanometer to Foot
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Foot value</returns>
        public static double NanometerToFoot(double nanometer)
        {
            return nanometer / LengthConstValues.NanoFoot;
        }

        /// <summary>
        /// Convert Foot to Nanometer
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Nanometer value</returns>
        public static double FootToNanometer(double foot)
        {
            return foot * LengthConstValues.NanoFoot;
        }

        /// <summary>
        /// Convert Nanometer to Inch
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Inch value</returns>
        public static double NanometerToInch(double nanometer)
        {
            return nanometer / LengthConstValues.NanoInch;
        }

        /// <summary>
        /// Convert Inch to Nanometer
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Nanometer value</returns>
        public static double InchToNanometer(double inch)
        {
            return inch * LengthConstValues.NanoInch;
        }

        /// <summary>
        /// Convert Nanometer to Nautical Mile
        /// </summary>
        /// <param name="nanometer"></param>
        /// <returns>Nautical mile value</returns>
        public static double NanometerToNauticalMile(double nanometer)
        {
            return nanometer / LengthConstValues.NanoNauticalmile;
        }

        /// <summary>
        /// Convert Nautical Mile to Nanometer
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Nanometer value</returns>
        public static double NauticalmileToNanometer(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.NanoNauticalmile;
        }

        /// <summary>
        /// Convert Mile to Yard
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Yard value</returns>
        public static double MileToYard(double mile)
        {
            return mile * LengthConstValues.MileYard;
        }

        /// <summary>
        /// Convert Yard to Mile
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Mile value</returns>
        public static double YardToMile(double yard)
        {
            return yard / LengthConstValues.MileYard;
        }

        /// <summary>
        /// Convert Mile to Foot
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Foot value</returns>
        public static double MileToFoot(double mile)
        {
            return mile * LengthConstValues.MileFoot;
        }

        /// <summary>
        /// Convert Foot to Mile
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Mile value</returns>
        public static double FootToMile(double foot)
        {
            return foot / LengthConstValues.MileFoot;
        }

        /// <summary>
        /// Convert Mile to Inch
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Inch value</returns>
        public static double MileToInch(double mile)
        {
            return mile * LengthConstValues.MileInch;
        }

        /// <summary>
        /// Convert Inch to Mile
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Mile Value</returns>
        public static double InchToMile(double inch)
        {
            return inch / LengthConstValues.MileInch;
        }

        /// <summary>
        /// Convert Mile to Nautical mile
        /// </summary>
        /// <param name="mile"></param>
        /// <returns>Nautical mile value</returns>
        public static double MileToNauticalmile(double mile)
        {
            return mile / LengthConstValues.MileNauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Mile
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Mile value</returns>
        public static double NauticalmiletoMile(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.MileNauticalmile;
        }

        /// <summary>
        /// Convert Yard to Foot
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Foot value</returns>
        public static double YardToFoot(double yard)
        {
            return yard * LengthConstValues.YardFoot;
        }

        /// <summary>
        /// Convert Foot to Yard
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Yard value</returns>
        public static double FootToYard(double foot)
        {
            return foot / LengthConstValues.YardFoot;
        }

        /// <summary>
        /// Convert Yard to Inch
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Inch value</returns>
        public static double YardtoInch(double yard)
        {
            return yard * LengthConstValues.YardInch;
        }

        /// <summary>
        /// Convert Inch to Yard
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Yard value</returns>
        public static double InchToYard(double inch)
        {
            return inch / LengthConstValues.YardInch;
        }

        /// <summary>
        /// Convert Yard to Nautical mile
        /// </summary>
        /// <param name="yard"></param>
        /// <returns>Nautical mile value</returns>
        public static double YardToNauticalmile(double yard)
        {
            return yard / LengthConstValues.YardNauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Yard
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Yard value</returns>
        public static double NauticalmileToYard(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.YardNauticalmile;
        }

        /// <summary>
        /// Convert Foot to Inch
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Inch value</returns>
        public static double FootToInch(double foot)
        {
            return foot * LengthConstValues.FeetInch;
        }

        /// <summary>
        /// Convert Inch to Foot
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Foot value</returns>
        public static double InchToFoot(double inch)
        {
            return inch / LengthConstValues.FeetInch;
        }

        /// <summary>
        /// Convert Foot to Nautical mile
        /// </summary>
        /// <param name="foot"></param>
        /// <returns>Nautical mile value</returns>
        public static double FootToNauticalmile(double foot)
        {
            return foot / LengthConstValues.FeetNauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to foot
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Foot value</returns>
        public static double NauticalmileToFoot(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.FeetNauticalmile;
        }

        /// <summary>
        /// Convert Inch to Nautical mile
        /// </summary>
        /// <param name="inch"></param>
        /// <returns>Nautical mile value</returns>
        public static double InchToNauticalmile(double inch)
        {
            return inch / LengthConstValues.InchNauticalmile;
        }

        /// <summary>
        /// Convert Nautical mile to Inch
        /// </summary>
        /// <param name="nauticalmile"></param>
        /// <returns>Inch value</returns>
        public static double NauticalmileToInch(double nauticalmile)
        {
            return nauticalmile * LengthConstValues.InchNauticalmile;
        }



    }
}
