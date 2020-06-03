using AJ.Exercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJ.Exercise.Extensions
{
    public static class DirectionExtensions
    {
        public static Direction RotateCounterClockwise(this Direction value)
        {
            return value switch
            {
                Direction.North => Direction.West,
                Direction.East => Direction.North,
                Direction.South => Direction.East,
                Direction.West => Direction.South,
                _ => throw new ArgumentException(message: "Direction error.")
            };
        }

        public static Direction RotateClockwise(this Direction value)
        {
            return value switch
            {
                Direction.North => Direction.East,
                Direction.East => Direction.South,
                Direction.South => Direction.West,
                Direction.West => Direction.North,
                _ => throw new ArgumentException(message: "Direction error.")
            };
        }
    }
}
