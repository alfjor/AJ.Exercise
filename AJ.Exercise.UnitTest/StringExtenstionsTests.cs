using AJ.Exercise.Enums;
using AJ.Exercise.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AJ.Exercise.UnitTest
{
    [TestClass]
    public class StringExtenstionsTests
    {
        [TestMethod]
        public void When_mapping_1_to_command_it_should_return_forward()
        {
            // Arrange

            var value = "1";

            // Act

            var result = value.MapStringToCommand();

            // Assert

            Assert.AreEqual(Command.Forward, result);
        }
    }
}
