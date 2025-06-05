using System;

namespace Search.library
{
    public class HashtableString
    {
        private string[] array;
        public int Length => throw new NotImplementedException();
        public HashtableString(int size)
        {
            array = new string[size];
        }

        public int Count(string value)
        {
            throw new NotImplementedException();
        }

        public void Add(string value)
        {
            var idx = CalcIndex(value);
            if (array[idx] != null)
                throw new Exception("The item cannot be added to the table");
            array[idx] = value;
        }

        public void Remove(string value)
        {
            var idx = CalcIndex(value);
            if (array[idx] == value)
                array[idx] = null;
        }

        public void Clear()
        {
            for (var i = 0; i < array.Length; i++)
                array[i] = null;
        }

        public bool Contains(string value)
        {
            var idx = CalcIndex(value);
            if (array[idx] == value)
                return true;

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
