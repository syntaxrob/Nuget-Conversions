# Units.Conversions Nuget
This is the project page for the Nuget package **Units.Conversions** which, once installed, allows you to convert the following units:

| Length      |  Temperature    | Speed               | Fuel Economy              | Frequency |
| ----------- | --------------- | ------------------- | ------------------------- | --------- |
| Kilometers  | Celsius         | Miles per hour      | Miles per gallon          | Hertz     |
| Meters      | Farenheit       | Feet per second     | Imperial miles per gallon | Kilohertz |
| Centimerters| Kelvin          | Meters per second   | Kilometers per liter      | Megahertz |
| Millimeters |                 | Kilometers per hour | Liters per 100km          | Gigahertz |
| Micrometers |                 | Knots               |
| Nanometers  |
| Miles       |
| Yards       |
| Feet        |
| Inches      |
| Nautical Miles|

| Area              |
| ----------------- |
| Square Kilometers |
| Square Meters     |
| Square Mile       |
| Square Yard       |
| Square Foot       |
| Square Inch       |
| Square Hectare    | 
| Square Acre       |

To use this package, add the relevant `using` statements:
* `using Conversions` - which gives access to the `Length` property
* `using Conversions.UnitsOfTemperature` - which gives access to the `Temperature` property
* `using Conversions.UnitsOfSpeed` - which gives access to the `Speed` property
* `using Conversions.UnitsOfFuelEconomy` - which gives access to the `FuelEconomy` property
* `using Conversions.UnitsOfFrequency` - which gives access to the `Frequency` property
* `using Conversions.UnitsOfArea` - which gives access to the `Area` property

For example:
```
using Conversions
using Conversions.UnitsOfTemperature;
using Conversions.UnitsOfSpeed;
using Conversions.UnitsOfFuelEconomy;
using Conversions.UnitsOfFrequency;
using Conversions.UnitsOfArea;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert 1 Foot to Centimeters");
            var cm = Length.FootToCentimeter(1);
            Console.WriteLine(cm);

            Console.WriteLine("Convert 10 degrees C to Farenheit");
            var F = Temperature.CelciusToFarenheit(10);
            Console.WriteLine(F);
            
            Console.WriteLine("Convert 60 mph to Kph");
            var kph = Speed.MilesPerHourToKilometersPerHour(60);
            Console.WriteLine(kph);
            
            Console.WriteLine("Convert 40 mpg to Kpl");
            var kpl = FuelEconomy.MilesPerGallonToKilometersPerLitre(40);
            Console.WriteLine(kpl);
            
            Console.WriteLine("Convert 1500 hertz to Kilohertz");
            var khtz = Frequency.HertzToKilohertz(1500);
            Console.WriteLine(khtz);
            
            Console.WriteLine("Convert 20 square kilometers to Acres");
            var acres = Area.SquareKilometerToAcre(20);
            Console.WriteLine(acres);
        }
    }
}
```
