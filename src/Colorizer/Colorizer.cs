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

    public static void WriteLine(string format, ConsoleColor color, params object[] args)
    {
        

        if (args?.Length>0)
        {
           var  parms=new Parm[args.Length];
            foreach (string item in args)
                parms.Append(new Parm { Value = item, Color = color });

            Write(format, color, parms);
        }
        else
        {
            WriteLine(format, color);
        }
        
         
    }

    public static void Write(string format, ConsoleColor formatColor, params Parm[] args)
    {

        Console.ResetColor();
        if (args == null || args.Length <= 0)
        {
            
            Console.ForegroundColor = formatColor;
            Console.Write(format);
        }
        else
        {
            List<KeyValuePair<int, string>> patterns = new List<KeyValuePair<int, string>>();
            for (int pos = 0; pos < args.Length; pos++)
                patterns.Add(new KeyValuePair<int, string>(pos, "{" + pos + "}"));

            var lastIndex = -1;

            for (int i = 0; i < patterns.Count; i++)
            {

                Console.ForegroundColor = formatColor;
                var item = patterns[i];
                //handle start case
                if (i == 0)
                {
                    var output = format.Split(new string[] { item.Value }, StringSplitOptions.None)[0];
                    Console.Write(output);
                    var formatIndex = format.IndexOf(item.Value);
                    if (formatIndex < 0) //invalid format
                        break;
                    Console.ForegroundColor = args[item.Key].Color;
                    Console.Write(args[item.Key].Value);
                    lastIndex = formatIndex + 3;
                }
                else
                {
                    var tempParmNum = (i - 1).ToString().Length + 2;
                    var parmNum = i.ToString().Length + 2;
                    var temp = patterns[i - 1];
                    var start = format.IndexOf(temp.Value);
                    var end = format.IndexOf(item.Value);
                    var length = end - start;
                    if (length < 1) //extra arguments passed
                        break; //invalid format
                    var output = format.Substring(start + tempParmNum, length - parmNum);
                    Console.Write(output);
                    Console.ForegroundColor = args[item.Key].Color;
                    Console.Write(args[item.Key].Value);
                    lastIndex = end + parmNum;
                }

            }

            //handle reset part
            if (lastIndex > 0 && lastIndex < format.Length)
            {
                var lastOutput = format.Substring(lastIndex);
                Console.ForegroundColor = formatColor;
                Console.Write(lastOutput);
            }
        }

    }

}



