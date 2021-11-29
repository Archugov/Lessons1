using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Reference_Value_Types
{
    class Test_10_3
    {
        static public void DelInArray<T>(ref T[] Array, int index)
        {
            T[] newArray = new T[Array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = Array[i];

            for (int i = index + 1; i < Array.Length; i++)
                newArray[i - 1] = Array[i];

            Array = newArray;
        }

        static public void DelFirst<T>(ref T[] Array)
        {
            DelInArray(ref Array, 0);
        }

        static public void DelLast<T>(ref T[] Array)
        {
            DelInArray(ref Array, Array.Length);
        }
    }
}
