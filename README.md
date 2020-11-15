# Units.Conversions Nuget
This is the project page for the Nuget package **Units.Conversions** which, once installed, allows you to convert the following units:

| Length  |  Temperature |
| ----------- | --------------- |
| Kilometers  | Celcius         |
| Meters      | Farenheit       |
| Centimerters| Kelvin          |
| Millimeters |                 |
| Micrometers |
| Nanometers  |
| Miles       |
| Yards       |
| Feet        |
| Inches      |
| Nautical Miles|

To use this package, add the relevant `using` statements:
* `using Conversions` - which gives access to the `Length` property
* `using Conversions.UnitsOfTemperature` - which gives access to the `Temperature` property

For example:
```
using Conversions
using Conversions.UnitsOfTemperature;

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
        }
    }
}
```