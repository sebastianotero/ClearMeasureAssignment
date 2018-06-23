using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReuseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReuseLibraryTest
{
    [TestClass]
    public class UnitTests
    {
        private readonly ReuseLibraryService _reuseLibraryService;

        public UnitTests()
        {
            _reuseLibraryService = new ReuseLibraryService();
        }

        [TestMethod]
        public void ReturnNullGivenValueOfLessThan1()
        {
            var result = _reuseLibraryService.ReuseLibraryMethod(0);

            Assert.IsNull(result);
        }


        [TestMethod]
        public void AssertExpectedActualAreEqual()
        {
            var expected = new List<string>() { "1", "2", "Fizz", "4", "Buzz" };


            var actual = _reuseLibraryService.ReuseLibraryMethod(5);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AssertListContainsValuesFrom1ToTheUserInput()
        {
            long param = 100000;
            var actual = _reuseLibraryService.ReuseLibraryMethod(param);
            Assert.IsTrue(actual.First() == "1");
            Assert.IsTrue(actual.Count() == param);
        }


        [TestMethod]
        public void AssertAllDivisibleBy3AreFizz()
        {

            List<string> values = _reuseLibraryService.ReuseLibraryMethod(100000);
            long val = 0;

            foreach (var item in values)
            {
                if (item == "Fizz")
                {
                    int index = values.IndexOf(item);

                    Assert.IsTrue((index + 1) % 3 == 0);
                }

                if (Int64.TryParse(item, out val))
                {
                    Assert.IsTrue(val % 3 != 0);
                }
            }
        }

        [TestMethod]
        public void AssertAllDivisibleBy5AreBuzz()
        {

            List<string> values = _reuseLibraryService.ReuseLibraryMethod(100000);
            long val = 0;

            foreach (var item in values)
            {
                if (item == "Buzz")
                {
                    int index = values.IndexOf(item);

                    Assert.IsTrue((index + 1) % 5 == 0);
                }

                if (Int64.TryParse(item, out val))
                {
                    Assert.IsTrue(val % 5 != 0);
                }
            }
        }

        [TestMethod]
        public void AssertAllDivisibleBy3And5AreFizzBuzz()
        {

            List<string> values = _reuseLibraryService.ReuseLibraryMethod(100000);
            long val = 0;

            foreach (var item in values)
            {
                if (item == "FizzBuzz")
                {
                    int index = values.IndexOf(item);

                    Assert.IsTrue(((index + 1) % 3 == 0) && (index + 1) % 5 == 0);
                }

                if (Int64.TryParse(item, out val))
                {
                    Assert.IsTrue((val % 5 != 0) && (val % 3 != 0));
                }
            }
        }

    }
}
