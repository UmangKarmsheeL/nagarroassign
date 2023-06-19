namespace LinkedList_Implementation
{
    public class LinkedListNode<T>//Here we are creating node.
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
