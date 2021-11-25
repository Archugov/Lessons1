using System;

namespace _10.Reference_Value_Types
{
    class main
    {

        static void Main(string[] args)
        {
            int[] array = { 3, 6, 9, 6, 7 };

            //Test_10_1.ResizeArray(ref array, 10);
            Test_10_2.AddInArray(ref array, 2, 55);
        }
    }
}
