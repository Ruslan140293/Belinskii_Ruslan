using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using MergeSort;
using System.Collections.Generic;

namespace MergeSort_Test
{
    [TestClass]
    public class MergeSortTest
    {
        private int[] GetNotSortedArray
        {
            get
            {
                var random = new Random();
                return Enumerable.Range(1, 10).OrderBy(r => random.Next()).ToArray();
            }
        }
        private List<int> GetNotSortedList
        {
            get
            {
                var random = new Random();
                return Enumerable.Range(1, 10).OrderBy(r => random.Next()).ToList();
            }
        }
        [TestMethod]
        public void mergeSortBase_notSortedArray_SortedArrayByAscending()
        {

            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderBy(x => x).ToArray();

            var resultArray = Merge_Sort.sort(notSortedArray);

            CollectionAssert.AreEqual(resultArray, sortedArrayByAscending);
        }
        [TestMethod]
        public void mergeSortBase_NotSortedList_SortedListByAscending()
        {
            var NotSortedList = GetNotSortedList;
            var SortedListByAscending = NotSortedList.OrderBy(x => x).ToList();
            var ResultList = Merge_Sort.Sort(NotSortedList);
            CollectionAssert.AreEqual(ResultList,SortedListByAscending);
        }
    }
}