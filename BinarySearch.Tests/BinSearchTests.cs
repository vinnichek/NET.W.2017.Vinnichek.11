using System;
using BinarySearch.Logic;
using NUnit.Framework;
using static BinarySearch.Logic.BinSearch;

namespace BinarySearch.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [TestCase(new int[] { 4, 6, 2, 5, 13, 5, 246, 3 }, 13, TestName = "BinarySearch_For_Valid_Input", ExpectedResult = 6)]

        [TestCase(null, 7, TestName = "BinarySearch_For_Empty_Array", ExpectedResult = typeof(ArgumentNullException))]
        [TestCase(new int[] {}, 7, TestName = "FindingElementInNullArray", ExpectedResult = typeof(ArgumentException))]

        public int TestBinarySearch(int[] array, int element)
        {
            Array.Sort(array);
            return array.BinarySearch(element, Comparator.comparatorForInt32);
        }
    }

}
