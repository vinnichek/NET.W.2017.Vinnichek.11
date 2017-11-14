using System;
namespace BinarySearch.Logic
{
    public static class BinSearch
    {
        /// <summary>
        /// Find index of element.
        /// </summary>
        /// <typeparam name="T">Type of element.</typeparam>
        /// <param name="array">Array for element search.</param>
        /// <param name="element">Search element.</param>
        /// <param name="comparator">Comparison criteria.</param>
        /// <returns>Index of search element. </returns>
        public static int BinarySearch<T>(this T[] array, T element, Func<T, T, int> comparator) 
        {
            if (array == null)
                throw new ArgumentNullException($"{nameof(array)} is null.");

            if (array.Length == 0)
                throw new ArgumentException($"{nameof(array)} is empty.");

            if (comparator == null)
                throw new ArgumentNullException($"{nameof(comparator)} is null.");

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middleIndex = left + (right - left) / 2;

                if (array[middleIndex].Equals(element))
                    return middleIndex;

                if (comparator(element, array[middleIndex]) == 1)
                    left = middleIndex + 1;
                else right = middleIndex - 1;
            }

            return -1;
        }
    }
}
