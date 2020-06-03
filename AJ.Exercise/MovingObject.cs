using AJ.Exercise.Enums;
using System;
using System.Linq;

namespace AJ.Exercise
{
    public class MovingObject
    {
        public MovingObject(string startingPosition, int maxX, int maxY)
        {
            var positions = startingPosition.Split(',');

            var x = Convert.ToInt32(positions[0]);
            var y = Convert.ToInt32(positions[1]);

            if (x > maxX || y > maxY)
            {
                throw new ArgumentException();
            }

            PositionX = x;
            PositionY = y;
            Direction = Direction.North;
        }

        public Direction Direction { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string CurrentPosition => $"[{PositionX}, {PositionY}]";

        public void SetStartingPosition()
        {

        }
    }
}
