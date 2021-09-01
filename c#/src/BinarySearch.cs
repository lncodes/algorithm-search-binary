using System;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Binary
{
    public sealed class BinarySearch
    {
        /// <summary>
        /// Method for reguler binary search
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="element"></param>
        /// <returns cref=int></returns>
        public int Search<T>(IReadOnlyList<T> data, T element) where T : IComparable
        {
            var minRangeIndex = 0;
            var maxRangeIndex = data.Count - 1;

            while (minRangeIndex <= maxRangeIndex)
            {
                var midIndex = minRangeIndex + (maxRangeIndex - minRangeIndex) / 2;
                if (data[midIndex].Equals(element))
                    return midIndex;

                if (data[midIndex].CompareTo(element) < 0)
                    minRangeIndex = midIndex + 1;
                else
                    maxRangeIndex = midIndex - 1;
            }

            return -1;
        }
    }
}
