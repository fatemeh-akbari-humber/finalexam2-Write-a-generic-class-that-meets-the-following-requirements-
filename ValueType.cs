using System;

using System;
using System.Collections.Generic;
using System.Linq;

namespace finalexam2
{
   public class ValueType<T> where T : struct, IComparable<T>
    {

        private List<T> _items;

        public ValueType()
        {
            _items = new List<T>();
        }

   
        public void AddItem(T item)
        {
            _items.Add(item);
        }

  
        public T GetItem(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            return _items[index];
        }

        public List<T> GetSortedDescending()
        {
            return _items.OrderByDescending(item => item).ToList();
        }
    }
}
