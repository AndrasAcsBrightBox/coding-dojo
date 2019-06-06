using NUnit.Framework;
using PigLatin;
using System;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void EmptyWord_Is_EmptyPigLatinWord()
        {
            Assert.AreEqual(string.Empty, Program.PigLatin(string.Empty));
        }

        [Test]
        public void Hello_Is_Ellohay()
        {
            Assert.AreEqual("Ellohay", Program.PigLatin("Hello"));
        }

        [Test]
        public void Codingdojo_Is_Odingdojooay()
        {
            Assert.AreEqual("Odingdojocay", Program.PigLatin("Codingdojo"));
        }

        [Test]
        public void WorksWithLongWord()
        {
            string a1000 = string.Empty;
            for (int i = 0; i < 1000; i++)
                a1000 += "a";

            Assert.AreEqual($"Ello{a1000}hay", Program.PigLatin($"Hello{a1000}"));
        }
    }
}
