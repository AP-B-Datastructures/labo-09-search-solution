using System;

namespace Search.library
{
    public class BinarySearchInt
    {
        static public int SearchSortedArray(int[] array, int value)
        {
            return SearchSortedArray(array, value, 0, array.Length - 1);
        }

        private static int SearchSortedArray(int[] list, int value, int minIndex, int maxIndex)
        {
            //base case: value was not found in the list
            if (minIndex > maxIndex)
                return -1;

            //TODO: find middle Index of the list
            int middleIndex = minIndex + (maxIndex - minIndex) / 2;

            //Check if that value == value => return the index (value was found) !
            if (list[middleIndex] == value)
                return middleIndex;

            //If that value is greater, repeat the same in the left side of the list
            else if (list[middleIndex] > value)
                return SearchSortedArray(list, value, minIndex, middleIndex - 1); 

            //If that value is smaller, repeat the same in th right side of the list
            else //if (list[middleIndex] < value)
                return SearchSortedArray(list, value, middleIndex  + 1, maxIndex);
        }
    }
}
