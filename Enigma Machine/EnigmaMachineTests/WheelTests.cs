using NUnit.Framework;
using Enigma_Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace Enigma_Machine.Tests
{
    [TestFixture()]
    public class WheelTests
    {
        [Test]
        public void RunThrough_ForwardInput_ReturnsCorrectOutput()
        {
            // Arrange
            Wheel wheel = new Wheel(1);
            bool forward = true;
            int input = 10;

            // Act
            int output = wheel.RunThrough(input, forward);

            // Assert
            Assert.AreEqual(13, output);
        }

        [Test]
        public void RunThrough_ReverseInput_ReturnsCorrectOutput()
        {
            // Arrange
            Wheel wheel = new Wheel(1);
            bool forward = false;
            int input = 16;

            // Act
            int output = wheel.RunThrough(input, forward);

            // Assert
            Assert.AreEqual(7, output);
        }

        [Test()]
        public void NextPosition_IncrementPosition_PositionIncremented()
        {
            // Arrange
            Wheel wheel = new Wheel(1);

            // Act
            wheel.NextPosition();

            // Assert
            Assert.AreEqual(1, wheel.Position);
        }

        [Test]
        public void NextPosition_WrapAround_PositionWrappedAround()
        {
            // Arrange
            Wheel wheel = new Wheel(1, 25);

            // Act
            wheel.NextPosition();

            // Assert
            Assert.AreEqual(0, wheel.Position);
        }

        [TestCase(1, 16, false)]
        [TestCase(1, 17, true)]
        [TestCase(1, 18, false)]
        public void RotateNextWheel_NotchPosition_ReturnsCorrectResult(int wheelNumber, int position, bool expected)
        {
            // Arrange
            Wheel wheel = new Wheel(wheelNumber, position);

            // Act
            bool result = wheel.RotateNextWheel();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}