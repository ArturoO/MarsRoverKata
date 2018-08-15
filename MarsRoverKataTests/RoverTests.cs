using MarsRoverKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKataTests
{
    public class RoverTests
    {
        [Test]
        public void GetCoordinates_RoverCreated_ReturnsInitialCoordinates()
        {
            string expected = "0:0:N";
            Rover rover = new Rover();
            Assert.That(rover.GetCoordinates(), Is.EqualTo(expected));
        }

        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        [TestCase("RRRRR", "0:0:E")]
        public void GetCoordinates_RoverTurnsRight_ReturnsCorrectCoordinates(string commands, string expected)
        {
            Rover rover = new Rover();
            rover.Execute(commands);
            Assert.That(rover.GetCoordinates(), Is.EqualTo(expected));
        }

        [TestCase("L", "0:0:W")]
        [TestCase("LL", "0:0:S")]
        [TestCase("LLL", "0:0:E")]
        [TestCase("LLLL", "0:0:N")]
        [TestCase("LLLLL", "0:0:W")]
        public void GetCoordinates_RoverTurnsLeft_ReturnsCorrectCoordinates(string commands, string expected)
        {
            Rover rover = new Rover();
            rover.Execute(commands);
            Assert.That(rover.GetCoordinates(), Is.EqualTo(expected));
        }

    }
}
