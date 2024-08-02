using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV03.Part02
{
    public class ListMethod<T>
    {
        private List<T> list;
        public bool Exists(Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (match(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T Find(Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (match(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (match(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public T FindLast(Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                {
                    return list[i];
                }
            }
            return default(T);
        }

        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }

        public bool TrueForAll(Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (!match(item))
                {
                    return false;
                }
            }
            return true;
        }

        public void PrintList()
        {
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
