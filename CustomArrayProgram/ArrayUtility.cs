using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayProgram
{
    public static class ArrayUtility
    {
        public static void Resize(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];
            for(int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
               
            }
            array = newArray;



        }
    }

}
