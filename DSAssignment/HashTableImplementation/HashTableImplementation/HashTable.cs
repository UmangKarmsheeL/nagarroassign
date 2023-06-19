using System;
using System.Collections.Generic;

namespace HashTableImplementation
{
    public class HashTable<K, V>//Here we are creating Hashtable contains array of HashNode objects.
    {
        private HashNode<K, V>[] _buckets;
        private int _size;

        public HashTable(int capacity)
        {
            if (capacity <=0)
            {
                throw new ArgumentException("Capacity must be a positive integer");
            }
            _buckets = new HashNode<K, V>[capacity];
            _size = 0;
        }

        public int Size()
        {
            return _size;
        }

        private int GetBucketIndex(K key)
        {
            int hashCode = key.GetHashCode();
            int index = hashCode % _buckets.Length;
            return index;
        }
        //Here are the methods of hash table.
        public void Insert(K key, V value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key), "Key cannot be null");
            }
            int index = GetBucketIndex(key);
            HashNode<K, V> head = _buckets[index];
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    head.Value = value;
                    return;
                }
                head = head.Next;
            }
            HashNode<K, V> newNode = new HashNode<K, V>(key, value);
            newNode.Next = _buckets[index];
            _buckets[index] = newNode;
            _size++;
        }

        public void Delete(K key)
        {
            int index = GetBucketIndex(key);
            HashNode<K, V> head = _buckets[index];
            HashNode<K, V> prev = null;
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    if (prev == null)
                    {
                        _buckets[index] = head.Next;
                    }
                    else
                    {
                        prev.Next = head.Next;
                    }
                    _size--;
                    return;
                }
                prev = head;
                head = head.Next;
            }
            throw new KeyNotFoundException("Key not found in hash table");
        }

        public bool Contains(K key)
        {
            int index = GetBucketIndex(key);
            HashNode<K, V> head = _buckets[index];
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    return true;
                }
                head = head.Next;
            }
            return false;
        }

        public V GetValueByKey(K key)
        {
            int index = GetBucketIndex(key);
            HashNode<K, V> head = _buckets[index];
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    return head.Value;
                }
                head = head.Next;
            }
            throw new KeyNotFoundException("Key not found in hash table");
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            for (int i = 0; i < _buckets.Length; i++)
            {
                HashNode<K, V> head = _buckets[i];
                while (head != null)
                {
                    yield return new KeyValuePair<K, V>(head.Key, head.Value);
                    head = head.Next;
                }
               
            }
        }

        public void Traverse()
        {
            foreach (KeyValuePair<K, V> pair in this)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }
        }
    }
}
