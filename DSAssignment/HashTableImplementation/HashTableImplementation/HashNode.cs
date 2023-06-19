namespace HashTableImplementation
{
    public class HashNode<K, V>//Here we are creating node which contain KVP and reference to next node.
    {
        public K Key { get; }
        public V Value { get; set; }
        public HashNode<K, V> Next { get; set; }

        public HashNode(K key, V value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
