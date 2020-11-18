﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Conversions.UnitsOfArea
{
    public class Area
    {
        private static class ConstValues
        {
            public const double SqKmSqmeter = 1000000;
            public const double SqKmSqmile = 2.59;
            public const double SqKmSqyard = 0.000001196;
            public const double SqKmSqfoot = 10760000;
            public const double SqKmSqinch = 1550000000;
            public const double SqKmHectare = 100;
            public const double SqKmAcre = 247.105;
            public const double SqmSqMile = 2590000;
            public const double SqmSqYard = 1.196;
            public const double SqmSqFoot = 10.764;
            public const double SqmSqInch = 1550;
            public const double SqmHectare = 10000;
            public const double SqmAcre = 4047;
            public const double SqmileSqyard = 3098000;
            public const double SqmileSqfoot = 27880000;
            public const double SqmileSqinch = 4014000000;
            public const double SqmileHectare = 259;
            public const double SqmileAcre = 259;
            public const double SqyardSqfoot = 9;
            public const double SqyardSqinch = 1296;
            public const double SqyardHectare = 11960;
            public const double SqyardAcre = 4840;
            public const double SqfootSqinch = 144;
            public const double SqfootHectare = 107639;
            public const double SqfootAcre = 43560;
            public const double SqinchHectare = 15500000;
            public const double SqinchAcre = 6273000;
            public const double HectareAcre = 2.471;
        }

        /// <summary>
        /// Convert Square Kilometers to Square Meters
        /// </summary>
        /// <param name="sqkm"></param>
        /// <returns>Meters squared</returns>
        public static double SquareKilometerToSquareMeter(double sqkm)
        {
            return sqkm * ConstValues.SqKmSqmeter;
        }

        /// <summary>
        /// Convert Square kilometers to Square miles
        /// </summary>
        /// <param name="sqkm"></param>
        /// <returns>Square Miles</returns>
        public static double SquareKilometerToSquareMile(double sqkm)
        {
            return sqkm / ConstValues.SqKmSqmile;
        }

        /// <summary>
        /// Convert Square Kilometers to square yards
        /// </summary>
        /// <param name="sqkm"></param>
        /// <returns>Square Yards</returns>
        public static double SquareKilometerToSquareYard(double sqkm)
        {
            return sqkm * ConstValues.SqKmSqyard;
        }

        /// <summary>
        /// Convert Square Kilometers to Square feet
        /// </summary>
        /// <param name="sqkm"></param>
        /// <returns>Square Feet</returns>
        public static double SquareKilometerToSquareFoot(double sqkm)
        {
            return sqkm * ConstValues.SqKmSqfoot;
        }

        /// <summary>
        /// Convert Square Kilometers to Square inch
        /// </summary>
        /// <param name="sqkm"></param>
        /// <returns>Square Inch</returns>
        public static double SquareKilometerToSquareInch(double sqkm)
        {
            return sqkm * ConstValues.SqKmSqinch;
        }

        /// <summary>
        /// Convert Square Kilometers to Hectares
        /// </summary>
        /// <param name="sqkm"></param>
        /// <returns>Hectares</returns>
        public static double SquareKilometerToHectare(double sqkm)
        {
            return sqkm * ConstValues.SqKmHectare;
        }

        /// <summary>
        /// Convert Square Kilometers to Acres
        /// </summary>
        /// <param name="sqkm"></param>
        /// <returns></returns>
        public static double SquareKilometerToAcre(double sqkm)
        {
            return sqkm * ConstValues.SqKmAcre;
        }

        /// <summary>
        /// Convert Square meters to Square Kilometers
        /// </summary>
        /// <param name="sqm"></param>
        /// <returns>Square Kilometers</returns>
        public static double SquareMeterToSquareKilometer(double sqm)
        {
            return sqm / ConstValues.SqKmSqmeter;
        }

        /// <summary>
        /// Convert Square meters to Square miles
        /// </summary>
        /// <param name="sqm"></param>
        /// <returns>Square miles</returns>
        public static double SquareMeterToSquareMile(double sqm)
        {
            return sqm / ConstValues.SqmSqMile;
        }

        /// <summary>
        /// Convert Square meters to Square yards
        /// </summary>
        /// <param name="sqm"></param>
        /// <returns>Square yards</returns>
        public static double SquareMeterToSquareYard(double sqm)
        {
            return sqm * ConstValues.SqmSqYard;
        }

        /// <summary>
        /// Convert Square meters to Square feet
        /// </summary>
        /// <param name="sqm"></param>
        /// <returns>Square feet</returns>
        public static double SquareMeterToSquareFoot(double sqm)
        {
            return sqm * ConstValues.SqmSqFoot;
        }

        /// <summary>
        /// Convert Square meters to Square inches
        /// </summary>
        /// <param name="sqm"></param>
        /// <returns>Square inches</returns>
        public static double SquareMeterToSquareInch(double sqm)
        {
            return sqm * ConstValues.SqmSqInch;
        }

        /// <summary>
        /// Convert Square meters to Hectares
        /// </summary>
        /// <param name="sqm"></param>
        /// <returns>Hectares</returns>
        public static double SquareMeterToHectare(double sqm)
        {
            return sqm / ConstValues.SqmHectare;
        }

        /// <summary>
        /// Convert Square meters to Acres
        /// </summary>
        /// <param name="sqm"></param>
        /// <returns>Acres</returns>
        public static double SquareMeterToAcre(double sqm)
        {
            return sqm / ConstValues.SqmAcre;
        }
    }
}
