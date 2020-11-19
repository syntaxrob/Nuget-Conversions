using System;
using System.Collections.Generic;
using System.Text;
using Conversions.UnitsOfArea;
using Xunit;

namespace UnitTests
{
    public class AreaTests
    {
        [Fact]
        public void SqKilometersAndSqMeters()
        {
            double expected = 1000000;
            double actual = Area.SquareKilometerToSquareMeter(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqKilometersAndSqMiles()
        {
            double expected = 0.3861003861003861;
            double actual = Area.SquareKilometerToSquareMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqKilometersAndSqYards()
        {
            double expected = 1.196e-6;
            double actual = Area.SquareKilometerToSquareYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqKilometersAndSqFeet()
        {
            double expected = 1.076e+7;
            double actual = Area.SquareKilometerToSquareFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqKilometersAndSqInches()
        {
            double expected = 1.55e+9;
            double actual = Area.SquareKilometerToSquareInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqKilometersAndHectares()
        {
            double expected = 100;
            double actual = Area.SquareKilometerToHectare(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqKilometersAndAcres()
        {
            double expected = 247.105;
            double actual = Area.SquareKilometerToAcre(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMetersAndSqMiles()
        {
            double expected = 3.861003861003861E-07;
            double actual = Area.SquareMeterToSquareMile(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMetersAndSqYards()
        {
            double expected = 1.196;
            double actual = Area.SquareMeterToSquareYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMetersAndSqFeet()
        {
            double expected = 10.764;
            double actual = Area.SquareMeterToSquareFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMetersAndSqInches()
        {
            double expected = 1550;
            double actual = Area.SquareMeterToSquareInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMetersAndSqHectares()
        {
            double expected = 1e-4;
            double actual = Area.SquareMeterToHectare(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMetersAndSqAcres()
        {
            double expected = 0.00024709661477637757;
            double actual = Area.SquareMeterToAcre(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMilesAndSqYards()
        {
            double expected = 3.098e+6;
            double actual = Area.SquareMileToSquareYard(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMilesAndSqFeet()
        {
            double expected = 2.788e+7;
            double actual = Area.SquareMileToSquareFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMilesAndSqInches()
        {
            double expected = 4.014e+9;
            double actual = Area.SquareMileToSquareInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMilesAndHectares()
        {
            double expected = 259;
            double actual = Area.SquareMileToHectare(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqMilesAndAcres()
        {
            double expected = 640;
            double actual = Area.SquareMileToAcre(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqYardAndSqFeet()
        {
            double expected = 9;
            double actual = Area.SquareYardToSquareFoot(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqYardAndSqInch()
        {
            double expected = 1296;
            double actual = Area.SquareYardToSquareInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqYardAndHectares()
        {
            double expected = 8.361204013377926E-05;
            double actual = Area.SquareYardToHectare(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqYardAndAcres()
        {
            double expected = 0.00020661157024793388;
            double actual = Area.SquareYardToAcre(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqFeetAndSqInches()
        {
            double expected = 144;
            double actual = Area.SquareFootToSquareInch(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqFeetAndHectares()
        {
            double expected = 9.290312990644655E-06;
            double actual = Area.SquareFootToHectare(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqFeetAndAcres()
        {
            double expected = 2.295684113865932E-05;
            double actual = Area.SquareFootToSquareAcre(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqInchesAndHectares()
        {
            double expected = 6.451612903225807E-08;
            double actual = Area.SquareInchToHectare(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SqInchesAndAcres()
        {
            double expected = 1.5941335883947074E-07;
            double actual = Area.SquareInchToAcre(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HectaresAndAcres()
        {
            double expected = 2.471;
            double actual = Area.HectareToAcre(1);
            Assert.Equal(expected, actual);
        }
    }
}
