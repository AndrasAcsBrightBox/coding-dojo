using BitPalindrom;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Example_Number_Is_BitPalindrom()
        {
            Assert.IsTrue(Program.IsBitPalindrom(3));
        }

        [Test]
        public void Example_Number_Is_Not_BitPalindrom()
        {
            Assert.IsFalse(Program.IsBitPalindrom(4));
        }

        [Test]
        public void IntMaxValue_Is_BitPalindrom()
        {
            Assert.IsTrue(Program.IsBitPalindrom(int.MaxValue));
        }

        [Test]
        public void Zero_Is_BitPalindrom()
        {
            Assert.IsTrue(Program.IsBitPalindrom(0));
        }

        [Test]
        public void Test_Against_Test_Data()
        {
            for(int i = 0; i < 20000; i++)
            {
                if (Program.IsBitPalindrom(i) != TestData.dict[i])
                    throw new Exception();
            }
        }

        [Test]
        public void PerformanceTest()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = -1000000; i < 1000000; i++)
            {
                Program.IsBitPalindrom(i);
            }
            sw.Stop();
            if (sw.Elapsed > new TimeSpan(0, 0, 6)) throw new Exception();
        }
    }
}
