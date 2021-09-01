using System;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Binary
{
    public sealed class RecursiveBinarySearch
    {
        /// <summary>
        /// Method for recrusive binary search
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="minRangeIndex"></param>
        /// <param name="maxRangeIndex"></param>
        /// <param name="element"></param>
        /// <returns cref=int></returns>
        public int Search<T>(IReadOnlyList<T> data, T element, int minRangeIndex, int maxRangeIndex) where T : IComparable
        {
            if (minRangeIndex <= maxRangeIndex)
            {
                var midIndex = minRangeIndex + (maxRangeIndex - minRangeIndex) / 2;

                if (data[midIndex].Equals(element))
                    return midIndex;

                return data[midIndex].CompareTo(element) < 0 ?
                    Search(data, element, midIndex + 1, maxRangeIndex)
                    : Search(data, element, minRangeIndex, midIndex - 1);
            }

            return -1;
        }
    }
}
