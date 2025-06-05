using System;
using Search.library.SinglyLinkedList;

namespace Search.library
{
    public class LinearSearchInt
    {
        public static int SearchArray(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }
        public static NodeInt SearchLinkedList(ListInt list, int value)
        {
            NodeInt node = list.First;
            while (node != null)
            {
                if (node.Value == value)
                {
                    return node;
                }
                node = node.Next;
            }
            return null;
        }
    }
}
