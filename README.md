# Units.Conversions Nuget
This is the project page for the Nuget package **Units.Conversions** which, once installed, allows you to convert the following units:

| Length      |  Temperature    | Speed               | Fuel Economy              |
| ----------- | --------------- | ------------------- | ------------------------- |
| Kilometers  | Celsius         | Miles per hour      | Miles per gallon          |
| Meters      | Farenheit       | Feet per second     | Imperial miles per gallon |
| Centimerters| Kelvin          | Meters per second   | Kilometers per liter      |
| Millimeters |                 | Kilometers per hour | Liters per 100km          |
| Micrometers |                 | Knots               |
| Nanometers  |
| Miles       |
| Yards       |
| Feet        |
| Inches      |
| Nautical Miles|

To use this package, add the relevant `using` statements:
* `using Conversions` - which gives access to the `Length` property
* `using Conversions.UnitsOfTemperature` - which gives access to the `Temperature` property
* `using Conversions.UnitsOfSpeed` - which gives access to the `Speed` property
* `using Conversions.UnitsOfFuelEconomy` - which gives access to the `FuelEconomy` property

For example:
```
using Conversions
using Conversions.UnitsOfTemperature;
using Conversions.UnitsOfSpeed;
using Conversions.UnitsOfFuelEconomy;

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
        }
    }
}
```
