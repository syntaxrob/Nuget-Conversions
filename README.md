# Units.Conversions Nuget
This is the project page for the Nuget package **Units.Conversions** which, once installed, allows you to convert the following units:

| Length      |  Temperature    | Speed               |
| ----------- | --------------- | ------------------- |
| Kilometers  | Celsius         | Miles per hour      |
| Meters      | Farenheit       | Feet per second     |
| Centimerters| Kelvin          | Meters per second   |
| Millimeters |                 | Kilometers per hour |
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

For example:
```
using Conversions
using Conversions.UnitsOfTemperature;
using Conversions.UnitsOfSpeed;

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
        }
    }
}
```
