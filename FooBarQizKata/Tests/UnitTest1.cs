using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FooBarQizKata
{
    [TestClass]
    public class UnitTest1
    {
        #region Tests Base Division
        [TestMethod]
        public void TestDivisibleBy3()
        {
            int nombre = 6;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("Foo", res);
        }

        [TestMethod]
        public void TestDivisibleBy5()
        {
            int nombre = 20;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("Bar", res);
        }

        [TestMethod]
        public void TestDivisibleBy7()
        {
            int nombre = 14;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("Qix", res);
        }
        #endregion

        #region Tests Base Contains
        [TestMethod]
        public void TestContient3()
        {
            int nombre = 13;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("Foo", res);
        }

        [TestMethod]
        public void TestContient5()
        {
            int nombre = 52;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("Bar", res);
        }

        [TestMethod]
        public void TestContient7()
        {
            int nombre = 17;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("Qix", res);
        }
        #endregion

        #region Given Tests
        [TestMethod]
        public void TestDigitApparitionOrder()
        {
            int nombre = 53;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("BarFoo", res);
        }

        [TestMethod]
        public void TestDivisibleByAndContains()
        {
            int nombre = 15;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("FooBarBar", res);
        }

        [TestMethod]
        public void TestDivisibleByAndIsComposedOnlyOf()
        {
            int nombre = 33;
            string res = FooBarQix.Transforme(nombre);
            Assert.AreEqual("FooFooFoo", res);
        }
        #endregion

        #region Other Tests
        [TestMethod]
        public void TestTill10()
        {
            List<string> awaited = new List<string>();
            awaited.Add("1");
            awaited.Add("2");
            awaited.Add("FooFoo");
            awaited.Add("4");
            awaited.Add("BarBar");
            awaited.Add("Foo");
            awaited.Add("QixQix");
            awaited.Add("8");
            awaited.Add("Foo");
            awaited.Add("Bar");

            for (int i = 1; i <= 10; i++)
            {
                Assert.AreEqual<string>(awaited[i - 1], FooBarQix.Transforme(i));
            }

        }

        [TestMethod]
        public void TestNoException()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine(FooBarQix.Transforme(i));
            }
        }

        [TestMethod]
        public void TestTill10Lol()
        {
            List<string> awaited = new List<string>();
            awaited.Add("1");
            awaited.Add("LolLol");
            awaited.Add("FooFoo");
            awaited.Add("Lol");
            awaited.Add("BarBar");
            awaited.Add("LolFoo");
            awaited.Add("QixQix");
            awaited.Add("Lol");
            awaited.Add("Foo");
            awaited.Add("LolBar");

            for (int i = 1; i <= 10; i++)
            {
                Assert.AreEqual<string>(awaited[i - 1], FooBarQix.Transforme(i));
            }

        }
        #endregion
    }
}