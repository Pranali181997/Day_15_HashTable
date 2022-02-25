using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_HashTable
{
    public class MyHashTable<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyHashTable(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
    
        protected int GetArrayPosition(K key)
        {
          int position = key.GetHashCode() % size;
          return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach(KeyValue<K,V> items in linkedList) 
            {
                if (items.key.Equals(key))
                {
                    return items.value;
                }
            }
            return default(V);
        }
        public void  Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> items = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(items);

        }
        public void Remove(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemfound = false;
            KeyValue<K, V> foundItem = default (KeyValue< K,V>);
            foreach(KeyValue<K,V>item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemfound = true;
                    foundItem = item;
                }
            }

        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
           LinkedList<KeyValue<K, V>> linkedList = items[position];
           if (linkedList == null)
           {
            linkedList = new LinkedList<KeyValue<K, V>>();
            items[position] = linkedList;
           }
        return linkedList;
        }

        internal void Set(string word, int value)
        {
            throw new NotImplementedException();
        }

        internal void Remove(string v)
        {
            throw new NotImplementedException();
        }

        internal void Display()
        {
            throw new NotImplementedException();
        }
    }

        public struct KeyValue<k, v>
        {
        public k key { set; get; }
        public v value { set; get; }
        }
}
