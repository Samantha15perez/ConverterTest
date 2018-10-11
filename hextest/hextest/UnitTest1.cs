using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DLLTEST;

namespace hextest
{
    [TestClass]
    public class UnitTest1
    {
        DLLTEST.Class1 DLLTest = new DLLTEST.Class1();

        [TestMethod]
        public void TestHex()
        {
            long i = 20;
            int q = 0;

            string[] X = new string[] { "14", "190", "1F40", "27100" };

            while (i > 160000)
            {
                string expected = DLLTest.ConvertToHex(i);
                string actual = X[q];

                Assert.AreEqual(expected, actual);
                i = (i * 20);
                q++;
            }



        }

        [TestMethod]
        public void TestOct()
        {
            long i = 20;
            int q = 0;

            string[] X = new string[] { "24", "620", "17500", "470400" };

            while (i > 160000)
            {
                string expected = DLLTest.ConvertToHex(i);
                string actual = X[q];

                Assert.AreEqual(expected, actual);
                i = (i * 20);
                q++;
            }
        }

        [TestMethod]
        public void TestBin()
        {
            long i = 20;
            int q = 0;

            string[] X = new string[] { "10100", "110010000", "10011100010000000", "111101000010010000000000" };

            while (i > 160000)
            {
                string expected = DLLTest.ConvertToBinary(i).ToString();
                string actual = X[q];

                Assert.AreEqual(expected, actual);
                i = (i * 20);
                q++;
            }
        }
    }
}
