using System;
using Xunit;
using System.IO;

namespace Lecture01.Tests
{
    public class ProgramTests
    {

        [Fact]
        public void isLeapYear_testsDivisableBy4ReturnsTrue()
        {
            var yearInput = 2004;

            var expected = true;
            var actual = Program.isLeapYear(yearInput);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void isLeapYear_testsDivisableBy100ReturnsFalse()
        {
            var yearInput = 2100;

            var expected = false;
            var actual = Program.isLeapYear(yearInput);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void isLeapYear_testsDivivableBy400ReturnsTrue(){
            var yearInput = 2400;
            
            var expected = true;
            var actual = Program.isLeapYear(yearInput);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void isLeapYear_testsDivisableBy4ReturnsFalse()
        {
            var yearInput = 2135;

            var expected = false;
            var actual = Program.isLeapYear(yearInput);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void isLeapYear_testsDivisableBy100ReturnsFalse2()
        {
            var yearInput = 30200;

            var expected = false;
            var actual = Program.isLeapYear(yearInput);

            Assert.Equal(expected, actual);
        }

    }
}
