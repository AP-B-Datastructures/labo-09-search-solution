using System;

namespace Search.library.SinglyLinkedList
{
    public class ListString
    {
        public NodeString First { get; private set; }
        public NodeString Last  { get; private set; }
        public bool IsEmpty => this.First == null;
        public int Length { get; private set; }

        public void Add(string value)
        {
            NodeString newValue = new NodeString(value);

            if (this.IsEmpty)
                this.First = newValue;
            else
                this.Last.Next = newValue;

            this.Last = newValue;
            this.Length++;
        }

        public NodeString Find(string value)
        {
            NodeString currentNode = this.First;

            while (currentNode != null && currentNode.Value != value)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public NodeString Remove(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == 0)
            {
                return RemoveFirst();
            }

            NodeString beforeIndex = this.First;

            for (int i = 1; i < index - 1; ++i)
            {
                beforeIndex = beforeIndex.Next;
            }

            NodeString toRemove = beforeIndex.Next;

            beforeIndex.Next = beforeIndex.Next.Next;

            this.Length--;
            return toRemove;
        }

        public NodeString Remove(string value)
        {
            NodeString toRemove = Find(value);
            NodeString beforeValue = First;
            

            while (beforeValue != null && beforeValue.Next != toRemove)
            {
                beforeValue = beforeValue.Next;
            }

            if (beforeValue == null)
                return null;

            beforeValue.Next = toRemove.Next;

            this.Length--;
            return toRemove;
        }

        public NodeString RemoveFirst()
        {
            if (this.IsEmpty)
            {
                throw new IndexOutOfRangeException("LinkedList is Empty. Cannot remove first element.");
            }

            if (this.Length == 1)
            {
                this.Last = null;
            }

            NodeString toRemove = this.First;

            this.First = this.First.Next;

            this.Length--;
            return toRemove;
        }

        public NodeString RemoveLast()
        {
            return Remove(this.Length - 1);
        }

        public void Clear()
        {
            this.First = null;
            this.Last = null;
            this.Length = 0;
        }

        public override string ToString()
        {
            NodeString node = this.First;

            var result = "";
            while (node != null)
            {
                result += node.ToString();
                node = node.Next;
                if (node != null)
                    result += " ";
            }

            return result;
        }
    }
}