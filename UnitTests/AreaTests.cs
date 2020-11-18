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
    }
}
