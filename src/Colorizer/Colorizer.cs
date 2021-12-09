
namespace Colorizer;

/// <summary>
/// Colorizer parameter type.
/// </summary>
public sealed class Parm
{
    public string Value { get; init; } = string.Empty;
    public ConsoleColor Color { get; init; }
}

/// <summary>
/// Colorizer parameter pattern matching type.
/// </summary>
internal sealed class Pattern
{
    public int ParmIndex { get; init; }
    public string Format { get; init; } = string.Empty;
    public int FormatIndex { get; init; }
}

/// <summary>
/// Colorize your Console output with this simple to use and extensible library.
/// </summary>
public static class Colorizer
{

    /// <summary>
    /// Print colorizer text based on provided string format and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.FormatException">format or args is null --OR-- format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format"> A composite format <see cref="string"/>.</param>
    /// <param name="args"> An <see cref="Parm"/> array that contains zero or more objects to format.</param>
    public static void Write(string format, params Parm[] args) => Write(format, ConsoleColor.Black, args);

    /// <summary>
    /// Print colorizer text based on provided string format,color and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.ArgumentNullException">format or args is null.</exception>
    /// <exception cref="System.FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="color"><see cref="ConsoleColor"/> type color value.</param>
    /// <param name="args">An <see cref="object"/> array that contains zero or more objects to format.</param>
    public static void WriteLine(string format, ConsoleColor color, params object[] args) => WriteLine(string.Format(format, args), color);

    /// <summary>
    /// Print colorizer text based on provided string format,color and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.ArgumentNullException">format or args is null.</exception>
    /// <exception cref="System.FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="color"><see cref="ConsoleColor"/> type color value.</param>
    /// <param name="args">An <see cref="object"/> array that contains zero or more objects to format.</param>
    public static void Write(string format, ConsoleColor color, params object[] args) => Write(string.Format(format, args), color);

    /// <summary>
    /// Print text based on provided string format and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.ArgumentNullException">format or args is null.</exception>
    /// <exception cref="System.FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="args">An <see cref="object"/> array that contains zero or more objects to format.</param>
    public static void WriteLine(string format, params object[] args) => WriteLine(string.Format(format, args), ConsoleColor.Black);
    /// <summary>
    /// Print text based on provided string format and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.ArgumentNullException">format or args is null.</exception>
    /// <exception cref="System.FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="args">An <see cref="object"/> array that contains zero or more objects to format.</param>
    public static void Write(string format, params object[] args) => Write(string.Format(format, args), ConsoleColor.Black);

    /// <summary>
    /// Print text based on provided color.
    /// </summary>
    /// <param name="text"><see cref="string"/></param>
    /// <param name="color"><see cref="ConsoleColor"/> type color value.</param>
    public static void Write(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();
    }

    /// <summary>
    /// Print text based on provided color.
    /// </summary>
    /// <param name="text"><see cref="string"/>.</param>
    /// <param name="color"><see cref="ConsoleColor"/> type color value.</param>
    public static void WriteLine(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    /// <summary>
    /// Print text based on provided string format and parameters.
    /// </summary>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="args">An <see cref="Parm"/> array that contains zero or more objects to format.</param>
    public static void WriteLine(string format, params Parm[] args)
    {
        Write(format, ConsoleColor.Black, args);
        Console.WriteLine(string.Empty);    
    }

    /// <summary>
    /// Print char based on provided color.
    /// </summary>
    /// <param name="value"><see cref="char"/> value.</param>
    /// <param name="color"><see cref="ConsoleColor"/> type color value</param>
    public static void Write(char value, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(value);
        Console.ResetColor();
    }

    /// <summary>
    /// Print colorizer text based on provided string format and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.FormatException">format or args is null --OR-- format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="formatColor"><see cref="ConsoleColor"/> type color value.</param>
    /// <param name="args">An <see cref="Parm"/> array that contains zero or more objects to format.</param>
    public static void WriteLine(string format, ConsoleColor formatColor, params Parm[] args)
    {
        Write(format, formatColor, args);
        Console.WriteLine(string.Empty);
    }

    /// <summary>
    /// Print colorizer text based on provided string format and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.FormatException">format or args is null --OR-- format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="formatColor"><see cref="ConsoleColor"/> type color value.</param>
    /// <param name="args">An <see cref="Parm"/> array that contains zero or more objects to format.</param>
    public static void Write(string format, ConsoleColor formatColor, params Parm[] args)
    {
        if (!HasFormat(format))
            throw new FormatException(nameof(format));

        if (!HasArgs(args))
            throw new FormatException(nameof(args));

        //ensure format is vallid
        _ = string.Format(format, args);

        // parms pattern collections
        HashSet<Pattern> patterns = GetPatterns(format, args.Length).ToHashSet();
        //write text
        for (int index = 0; index < format.Length;)
        {
            var pattern = patterns.SingleOrDefault(x => x.FormatIndex == index);
            if (pattern != null)
            {
                var parm = args[pattern.ParmIndex];
                Write(parm.Value, parm.Color);
                index += pattern.Format.Length;
            }
            else
            {
                Write(format[index], formatColor);
                index++;
            }
        }

    }

    /// <summary>
    ///  Print colorizer text based on provided string format ,format color and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.ArgumentNullException">format or args is null.</exception>
    /// <exception cref="System.FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="formatColor"><see cref="ConsoleColor"/> type color value.</param>
    /// <param name="argColor"><see cref="ConsoleColor"/> type color value.</param>
    /// <param name="args">An <see cref="string"/> array that contains zero or more objects to format.</param>

    public static void WriteLine(string format, ConsoleColor formatColor, ConsoleColor argColor, params string[] args)
    {
        Write(format, formatColor, argColor,args);
        Console.WriteLine(string.Empty);
    }
    /// <summary>
    ///  Print colorizer text based on provided string format ,format color and parameters.
    /// </summary>
    /// <para>
    /// <exception cref="System.ArgumentNullException">format or args is null.</exception>
    /// <exception cref="System.FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
    /// </para>
    /// <param name="format">A composite format <see cref="string"/>.</param>
    /// <param name="formatColor"><see cref="ConsoleColor"/> type color value.</param>
    /// <param name="argColor"><see cref="ConsoleColor"/> type color value.</param>
    /// <param name="args">An <see cref="string"/> array that contains zero or more objects to format.</param>
 
    public static void Write(string format, ConsoleColor formatColor, ConsoleColor argColor, params string[] args)
    {
        if (!HasFormat(format))
            throw new FormatException(nameof(format));
 
        //ensure format is vallid
        _ = string.Format(format, args);

        // parms pattern collections
        HashSet<Pattern> patterns = GetPatterns(format, args.Length).ToHashSet();
        //write text
        for (int index = 0; index < format.Length;)
        {
            var pattern = patterns.SingleOrDefault(x => x.FormatIndex == index);
            if (pattern != null)
            {
                Write(args[pattern.ParmIndex]?.ToString() ?? string.Empty, argColor);
                index += pattern.Format.Length;
            }
            else
            {
                Write(format[index], formatColor);
                index++;
            }
        }
    }
    /// <summary>
    ///  Check provided format string.
    ///  <para>
    ///  It return true if string provided else false.
    ///  </para>
    /// </summary>
    /// <param name="format"><see cref="string"/></param>
    /// <returns><see cref="bool"/></returns>
    private static bool HasFormat(string format) => !string.IsNullOrEmpty(format) && !string.IsNullOrWhiteSpace(format) && format.Trim().Length > 0;
    /// <summary>
    /// Check provided arguments.
    /// <para>
    ///  It return true if any parameter supplied else false.
    /// </para>
    /// </summary>
    /// <param name="args"><see cref="Parm[]"/> </param>
    /// <returns><see cref="bool"/></returns>
    private static bool HasArgs(Parm[] args) => args?.Length > 0;

    /// <summary>
    /// Get patterns based on number of args provided.
    /// </summary>
    /// <param name="format"></param>
    /// <param name="argsCount"></param>
    /// <returns></returns>
    /// <exception cref="FormatException"></exception>
    private static IEnumerable<Pattern> GetPatterns(string format, int argsCount)
    {

        for (int pos = 0; pos < argsCount; pos++)
        {
            var pattern = "{" + pos + "}";
            var patternIndex = format.IndexOf(pattern);
            if (patternIndex == -1)
                throw new FormatException(nameof(format));
            yield return new Pattern { ParmIndex = pos, Format = pattern, FormatIndex = patternIndex };
        }
     
    }

}



