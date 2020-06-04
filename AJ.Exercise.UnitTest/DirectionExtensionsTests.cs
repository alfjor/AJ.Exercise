using AJ.Exercise.Enums;
using AJ.Exercise.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJ.Exercise.UnitTest
{

    [TestClass]
    public class DirectionExtensionsTests
    {
        [TestMethod]
        public void When_rotate_clockwise_from_north_it_should_return_east()
        {
            // Arrange

            var value = Direction.North;

            // Act

            var result = value.RotateClockwise();

            // Assert

            Assert.AreEqual(Direction.East, result);
        }

        [TestMethod]
        public void When_rotate_counterclockwise_from_west_it_should_return_south()
        {
            // Arrange

            var value = Direction.West;

            // Act

            var result = value.RotateCounterClockwise();

            // Assert

            Assert.AreEqual(Direction.South, result);
        }
    }
}
