using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Reference_Value_Types
{
    /* 1.
     * Написать метод Resize, изменяющий количество элементов массива
     * Метод должен иметь возможность увеличить или уменьшить количество элементов массива
     * 
     * 1.
     * Write a Resize method that changes the number of elements in the array
     * The method must be able to increase or decrease the number of array elements
     */
    class Test_10_1
    {
        static public void ResizeArray<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }
}
