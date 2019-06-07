using NUnit.Framework;
using SevenSegments;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Five_IsRespresented_Like_A_Five()
        {
            var expectedResult = @" __ 
|   
|__ 
   |
 __|";
            var result = Program.GetSevenSegments(5);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Eight_Is_Represented_Like_An_Eight()
        {
            var expectedResult = @" __ 
|  |
|__|
|  |
|__|";
            var result = Program.GetSevenSegments(8);
            Assert.AreEqual(expectedResult, result);
        }

    }
}
