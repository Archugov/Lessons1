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
        static public void AddInArray<T>(ref T[] Array, uint index, T value)
        {
            T[] newArray = new T[Array.Length + 1];
            newArray[index] = value;

            for (uint i = 0; i < index; i++)
                newArray[i] = Array[i];

            for (uint i = index; i < newArray.Length; i++)
                newArray[i] = Array[i];

            Array = newArray;
        }
    }
}
