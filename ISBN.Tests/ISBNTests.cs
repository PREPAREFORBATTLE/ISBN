using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISBN;

namespace ISBN.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check1()
        {
            // arrange
            string x = "0-1000-0010-X";
            bool expected = true;

            // act
            bool total = ISBNcheck.Valid(x);

            // assert
            Assert.AreEqual(expected, total);
        }
        [TestMethod]
        public void Check2()
        {
            // arrange
            string x = "0-7475-3269-9";
            bool expected = true;

            // act
            bool total = ISBNcheck.Valid(x);

            // assert
            Assert.AreEqual(expected, total);
        }
        [TestMethod]
        public void digits11()
        {
            // arrange
            string x = "0-7475-3269-93";
            bool expected = false;

            // act
            bool total = ISBNcheck.Valid(x);

            // assert
            Assert.AreEqual(expected, total);
        }
        [TestMethod]
        public void digits9()
        {
            // arrange
            string x = "0-7475-3269";
            bool expected = false;

            // act
            bool total = ISBNcheck.Valid(x);

            // assert
            Assert.AreEqual(expected, total);
        }
        [TestMethod]
        public void check3()
        {
            // arrange
            string x = "966-7343-29-4";
            bool expected = true;

            // act
            bool total = ISBNcheck.Valid(x);

            // assert
            Assert.AreEqual(expected, total);
        }
        [TestMethod]
        public void check4()
        {
            // arrange
            string x = "5-06-002611-5";
            bool expected = false;
            // act
            bool total = ISBNcheck.Valid(x);

            // assert
            Assert.AreEqual(expected, total);
        }
        [TestMethod]
        public void check5()
        {
            // arrange
            string x = "5-02-013850-9";
            bool expected = true;
            // act
            bool total = ISBNcheck.Valid(x);

            // assert
            Assert.AreEqual(expected, total);
        }
    }
}
