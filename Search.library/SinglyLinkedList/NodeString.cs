using System;

namespace Search.library.SinglyLinkedList
{
    public class NodeString
    {
        public string Value { get; set; }
        public NodeString Next { get; set; }

        public NodeString(string value = "")
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
