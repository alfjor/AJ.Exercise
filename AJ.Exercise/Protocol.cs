using AJ.Exercise.Enums;
using AJ.Exercise.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJ.Exercise
{
    /// <summary>
    /// My assumtion is that a protocol is a given combination of commands.
    /// </summary>
    public class Protocol
    {
        public List<Command> CreateProtocolFromString(string[] input)
        {
            var result = new List<Command>();

            foreach (var item in input)
            {
                result.Add(item.MapStringToCommand());
            }

            return result;
        }
    }
}
