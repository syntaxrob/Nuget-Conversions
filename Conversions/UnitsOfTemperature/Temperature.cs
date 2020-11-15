using System;
using System.Collections.Generic;
using System.Text;

namespace Conversions.UnitsOfTemperature
{
    public class Temperature
    {
        /// <summary>
        /// Convert Celcius to Farenheit
        /// </summary>
        /// <param name="celius"></param>
        /// <returns>Farenheit</returns>
        public static double CelciusToFarenheit(double celius)
        {
            return (celius * 1.8) + 32;
        }

        /// <summary>
        /// Convert Celcius to Kelvin
        /// </summary>
        /// <param name="celcius"></param>
        /// <returns>Kelvin</returns>
        public static double CelciusToKelvin(double celcius)
        {
            return celcius + 273.15;
        }

        /// <summary>
        /// Convert Farenheit to Celcius
        /// </summary>
        /// <param name="farenheit"></param>
        /// <returns>Celcius</returns>
        public static double FarenheitToCelcius(double farenheit)
        {
            return (farenheit - 32) * 0.55555555555555555555555555555556;
        }

        /// <summary>
        /// Convert Farenheit to Kelvin
        /// </summary>
        /// <param name="farenheit"></param>
        /// <returns>Kelvin</returns>
        public static double FarenheitToKelvin(double farenheit)
        {
            return ((farenheit - 32) * 0.55555555555555555555555555555556) + 273.15;
        }

        /// <summary>
        /// Convert Kelvin to Celcius
        /// </summary>
        /// <param name="kelvin"></param>
        /// <returns>Celcius</returns>
        public static double KelvinToCelcius(double kelvin)
        {
            return kelvin - 273.15;
        }

        /// <summary>
        /// Convert Kelvin to Farenheit
        /// </summary>
        /// <param name="kelvin"></param>
        /// <returns>Farenheit</returns>
        public static double KelvinToFarenheit(double kelvin)
        {
            return ((kelvin - 273.15) * 1.8) + 32;
        }
    }
}
