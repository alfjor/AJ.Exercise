using System;
using System.Collections.Generic;
using System.Text;

namespace AJ.Exercise.Extensions
{
    public static class MovingObjectExtensions
    {
        public static bool ValidateMove(this MovingObject value, int maxX, int maxY)
        {
            var positionX = value.PositionX;
            var positionY = value.PositionY;

            if (positionX > maxX || positionY > maxY || positionX < 0 || positionY < 0)
            {
                return false;
            }

            return true;
        }
    }
}
