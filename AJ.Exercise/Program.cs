using AJ.Exercise.Enums;
using AJ.Exercise.Extensions;
using System;
using System.Collections.Generic;

namespace AJ.Exercise
{
    public class Program
    {
        private static int[,] workingArray;

        public static void Main(string[] args)
        {
            Console.WriteLine("********* WELCOME TO MY EXERCISE PROJECT *********" + Environment.NewLine);

            Console.WriteLine("Insert size of matrix:");
            var sizeOfMatrix = Console.ReadLine();

            Console.WriteLine("Insert startposition of object:");
            var startingPosition = Console.ReadLine();

            Console.WriteLine("Insert commands in one line:");
            var commands = Console.ReadLine();

            var matrix = CreateMatrix(sizeOfMatrix);
            var maxX = matrix.GetLength(0);
            var maxY = matrix.GetLength(1);
            
            try
            {
                var movingObject = new MovingObject(startingPosition, maxX, maxY);

                Simulate(commands, movingObject, maxX, maxY);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Result: [-1, -1]");
            }
        }

        public static void Simulate(string commands, MovingObject movingObject, int maxX, int maxY)
        {
            var protocol = new Protocol();
            var commandList = protocol.CreateProtocolFromString(commands.Split(','));

            foreach (var command in commandList)
            {
                if (command == Command.End)
                {
                    Console.WriteLine("¨Result: " + movingObject.CurrentPosition);
                }
                else if (command == Command.Forward)
                {
                    MovingObjectStepForward(movingObject);
                    
                    if (!movingObject.ValidateMove(maxX, maxY))
                    {
                        throw new ArgumentException();
                    }
                }
                else if (command == Command.Backwards)
                {
                    MovingObjectStepBackwards(movingObject);
                    
                    if (!movingObject.ValidateMove(maxX, maxY))
                    {
                        throw new ArgumentException();
                    }
                }
                else if (command == Command.Clockwise90Degrees)
                {
                    movingObject.Direction = movingObject.Direction.RotateClockwise();
                }
                else if (command == Command.CounterClockwise90Degrees)
                {
                    movingObject.Direction = movingObject.Direction.RotateCounterClockwise();
                }
            }
        }

        private static void MovingObjectStepBackwards(MovingObject movingObject)
        {
            if (movingObject.Direction == Direction.North)
            {
                movingObject.PositionY++;
            }
            else if (movingObject.Direction == Direction.South)
            {
                movingObject.PositionY--;
            }
            else if (movingObject.Direction == Direction.East)
            {
                movingObject.PositionX--;
            }
            else if (movingObject.Direction == Direction.West)
            {
                movingObject.PositionX++;
            }
        }

        private static void MovingObjectStepForward(MovingObject movingObject)
        {
            if (movingObject.Direction == Direction.North)
            {
                movingObject.PositionY--;
            }
            else if (movingObject.Direction == Direction.South)
            {
                movingObject.PositionY++;
            }
            else if (movingObject.Direction == Direction.East)
            {
                movingObject.PositionX++;
            }
            else if (movingObject.Direction == Direction.West)
            {
                movingObject.PositionX--;
            }
        }

        public static int[,] CreateMatrix(string size)
        {
            var sizeOfMatrix = size.Split(',');

            return new int[Convert.ToInt32(sizeOfMatrix[0]), Convert.ToInt32(sizeOfMatrix[1])];
        }
    }
}
