using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
    public class MyStorage<T>
    {
        private int size;
        private T[] arr;
        public MyStorage()
        {
            size = 0;
        }
        public MyStorage(int size)
        {
            this.size = size;
            arr = new T[size];
        }
        public void pushBack(T obj)
        {
            T[] newArr;
            newArr = new T[size+1];

            for (int i = 0; i < size; i++)
                newArr[i] = arr[i];

            newArr[size] = obj;
            size++;
            arr = newArr;
        }

        public void pushFront(T obj)
        {
            T[] newArr;
            newArr = new T[size + 1];
            for (int i = 0; i < size; i++)
                newArr[i + 1] = arr[i];

            newArr[0] = obj;
            size++;
            arr = newArr;
        }

        public void popBack()
        {
            size--;
            T[] newArr;
            newArr = new T[size];
            for (int i = 0; i < size; i++)
                newArr[i] = arr[i];
            arr = newArr;
        }
        public void popFront()
        {
            size--;
            T[] newArr;
            newArr = new T[size];
            for (int i = 0; i < size; i++)
                newArr[i] = arr[i + 1];

            arr = newArr;
        }

        public void insert(int index, T obj)
        {
            if (index >= size)
            {
                return;
            }
            T[] newArr;
            newArr = new T[size + 1];
            for (int i = 0; i < index; i++)
                newArr[i] = arr[i];

            newArr[index] = obj;
            size++;

            for (int i = index + 1; i < size; i++)
                newArr[i] = arr[i - 1];

            arr = newArr;
        }

        public void erase(int index)
        {
            if (index >= size)
            {
                return;
            }
            T[] newArr;
            newArr = new T[size - 1];
            for (int i = 0; i < index; i++)
                newArr[i] = arr[i];

            for (int i = index + 1; i < size; i++)
                newArr[i - 1] = arr[i];

            size--;
            arr = newArr;
        }
        public T getObject(int index)
        {
            return arr[index];
        }
        public void setObject(int index, T obj)
        {
            if (index < size)
                arr[index] = obj;
        }
        public int getSize()
        {
            return size;
        }

        public T last()
        {
            return arr[size-1];
        }
    }
}
