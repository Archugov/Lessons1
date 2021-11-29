using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Reference_Value_Types
{
    /* 
    * 2.
    * Написать методы для добавления элемента в начало массива, в конец и по индексу
    * 
    * 2.
    * Write methods for adding an element to the beginning of an array, to the end and by index
    */
    class Test_10_2
    {
        static public void AddInArray<T>(ref T[] Array, int index, T value)
        {
            T[] newArray = new T[Array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
                newArray[i] = Array[i];

            for (int i = index; i < Array.Length; i++)
                newArray[i + 1] = Array[i];

            Array = newArray;
        }

        static public void AddFirst<T>(ref T[] Array, T value)
        {
            AddInArray(ref Array, 0, value);
        }

        static public void AddLast<T>(ref T[] Array, T value)
        {
            AddInArray(ref Array, Array.Length, value);
        }
    }
}
