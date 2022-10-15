using NUnit.Framework;
using SortedName;

namespace SortedName.Tests
{
    public class SortedNameTest
    {
        [TestCase("Dionisius Adji Nugroho","Nugroho Dionisius Adji")]
        [TestCase("FirstName SecondName LastName", "LastName FirstName SecondName")]
        [TestCase("TestingName Last", "Last TestingName")]
        public void TestSorterName(string input,string expected)
        {
            string actual = SortFunction.Sorter(input);
            Assert.AreEqual(expected,actual,"The Sorter Function is not working correctly.");
        }


    }
}