using AJ.Exercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJ.Exercise.Extensions
{
    public static class StringExtensions
    {
        public static Command MapStringToCommand(this string value)
        {
            return value switch
            {
                "0" => Command.End,
                "1" => Command.Forward,
                "2" => Command.Backwards,
                "3" => Command.Clockwise90Degrees,
                "4" => Command.CounterClockwise90Degrees,
                _ => throw new ArgumentException(message: "Command not found")
            };
        }
    }
}
