# Colorizer
The [Colorize](https://www.nuget.org/packages/Colorizer) library is used to colorized console output with this simple to use and extensible library.
![image](https://github.com/VikashChauhan51/Colorizer/assets/14816038/f6c909f2-4060-43d7-b4e8-040158a52b7d)


## Quick Start Example

```C#
using Colorizer;

// string format pattern string
string dream = "a dream of {0} and {1} and {2} and {3} and {4} and {5} and {6} and {7} and {8} and {9}...";

// parameters

string[] fruits = new string[]
{
    "bananas",
    "strawberries",
    "mangoes",
    "pineapples",
    "cherries",
    "oranges",
    "apples",
    "peaches",
    "plums",
    "melons"
};

ConsoleColorizer.WriteLine(dream,ConsoleColor.Gray,ConsoleColor.Yellow, fruits);

```

## Format With Parms Example:

```C#
using Colorizer;

// print with sequntial parameters
ConsoleColorizer.WriteLine("Hello,first {0} second {1} third {2} forth {3} fifth {4} sixth {5} seventh {6} eighth {7} nineth {8} tenth {9} rest {10} World!", ConsoleColor.White,
    new Parm { Value = "1", Color = ConsoleColor.Green },
    new Parm { Value = "2", Color = ConsoleColor.Yellow },
    new Parm { Value = "3", Color = ConsoleColor.Blue },
    new Parm { Value = "4", Color = ConsoleColor.Magenta },
    new Parm { Value = "5", Color = ConsoleColor.Cyan },
    new Parm { Value = "6", Color = ConsoleColor.Gray },
    new Parm { Value = "7", Color = ConsoleColor.Green },
    new Parm { Value = "8", Color = ConsoleColor.DarkYellow },
    new Parm { Value = "9", Color = ConsoleColor.White },
    new Parm { Value = "10", Color = ConsoleColor.Cyan },
    new Parm { Value = "11", Color = ConsoleColor.Green });

```
## Parms Only Example:

```C#
using Colorizer;

var parms = new[]
{
            new Parm { Value = "bananas", Color = ConsoleColor.Green },
            new Parm { Value = "strawberries", Color = ConsoleColor.Yellow },
            new Parm { Value = "mangoes", Color = ConsoleColor.Blue },
            new Parm { Value = "pineapples", Color = ConsoleColor.Magenta },
            new Parm { Value = "cherries", Color = ConsoleColor.Cyan },
            new Parm { Value = "oranges", Color = ConsoleColor.Gray },
            new Parm { Value = "apples", Color = ConsoleColor.Green },
            new Parm { Value = "peaches", Color = ConsoleColor.DarkYellow },
            new Parm { Value = "plums", Color = ConsoleColor.White },
            new Parm { Value = "melons", Color = ConsoleColor.Cyan },
            new Parm { Value = "enjoy...", Color = ConsoleColor.Green }
};

ConsoleColorizer.WriteSpaceLine(parms);

```
