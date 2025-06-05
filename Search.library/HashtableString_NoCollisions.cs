using System;
using Search.library.SinglyLinkedList;

namespace Search.library
{
    public class HashtableString_NoCollisions
    {
        private ListString[] array;
        public int Length => throw new NotImplementedException();

        public HashtableString_NoCollisions(int size)
        {
            array = new ListString[size]; 
        }

        public int Count(string value)
        {
            throw new NotImplementedException();
        }

        public void Add(string value)
        {
            var idx = CalcIndex(value);
            if (array[idx] == null)
                array[idx] = new ListString();  //make sure that the LL is created

            array[idx].Add(value);
        }

        public void Remove(string value)
        {
            var idx = CalcIndex(value);
            array[idx].Remove(value);
        }

        public void Clear()
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] != null)
                    array[i].Clear();
        }

        public bool Contains(string value)
        {
            var idx = CalcIndex(value);
            if (array[idx] != null)
                return array[idx].Find(value) != null;
            return false;
        }


        private int CalcIndex(string text)
        {
            var hash = CalculateHash(text);

            return Math.Abs(hash) % array.Length;
        }

        private int CalculateHash(string value)
        {
            return value.GetHashCode();
        }
    }
}
