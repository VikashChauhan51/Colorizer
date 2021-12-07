using System;
using System.Collections.Generic;

namespace Colorizer;

public sealed class Parm
{
    public string Value { get; init; } = string.Empty;
    public ConsoleColor Color { get; init; }
}

public static class Colorizer
{

    private const int DEFAULT_PATTERN_LENGTH = 2;


    public static void Write(string format, params Parm[] args) => Write(format, ConsoleColor.Black, args);
    public static void WriteLine(string format, ConsoleColor color, params object[] args) => WriteLine(string.Format(format, args), color);
    public static void Write(string format, ConsoleColor color, params object[] args) => Write(string.Format(format, args), color);
    public static void WriteLine(string format, params object[] args) => WriteLine(string.Format(format, args), ConsoleColor.Black);
    public static void Write(string format, params object[] args) => Write(string.Format(format, args), ConsoleColor.Black);
    public static void Write(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();
    }
    public static void WriteLine(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
    public static void WriteLine(string format, params Parm[] args)
    {
        Write(format, ConsoleColor.Black, args);
        Console.WriteLine(string.Empty);    
    }

    public static void Write(string format, ConsoleColor formatColor, params Parm[] args)
    {   
        if (HasFormat(format) && HasArgs(args))
        {
            var patterns = new List<KeyValuePair<int, string>>();
            for (int pos = 0; pos < args.Length; pos++)
                patterns.Add(new KeyValuePair<int, string>(pos, "{" + pos + "}"));

            var lastIndex = -1;

            for (int i = 0; i < patterns.Count; i++)
            {
                var pattern = patterns[i];
                //handle start case
                if (i == 0)
                {
                    Write(format.Split(new string[] { pattern.Value }, StringSplitOptions.None)[0], formatColor);
                    var formatIndex = format.IndexOf(pattern.Value);
                    if (formatIndex < 0) //invalid format
                        break;
                    WritetParam(pattern.Key);
                    lastIndex = formatIndex + DEFAULT_PATTERN_LENGTH + 1; //length of zero is 1.
                }
                else
                {
                    var lastParmNum = (i - 1).ToString().Length + DEFAULT_PATTERN_LENGTH;
                    var parmNum = i.ToString().Length + DEFAULT_PATTERN_LENGTH;
                    var lastParm = patterns[i - 1];
                    var start = format.IndexOf(lastParm.Value)+ lastParmNum;
                    var end = format.IndexOf(pattern.Value);
                    var length = end - start;
                    if (length < 1) //extra arguments passed
                        break; //invalid format
                    Write(format.Substring(start, length), formatColor);
                    WritetParam(pattern.Key);
                    lastIndex = end + parmNum;
                }

            }
            //handle rest part
            if (lastIndex > 0 && lastIndex < format.Length)
                Write(format.Substring(lastIndex), formatColor);
        }
        else if (HasFormat(format) && !HasArgs(args))
            Write(format, formatColor);
        //local function to write parameter value with color.
        void WritetParam(int index)
        {
            var parm = args[index];
            Write(parm.Value, parm.Color);
        };
        
       
    }
    private static bool HasFormat(string format) => !string.IsNullOrEmpty(format) && !string.IsNullOrWhiteSpace(format) && format.Trim().Length > 0;
    private static bool HasArgs(Parm[] args) => args.Length > 0;

}



