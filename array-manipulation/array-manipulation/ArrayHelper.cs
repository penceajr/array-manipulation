using System;
using System.Collections.Generic;
using System.Text;

namespace array_manipulation
{
    class ArrayHelper
    {
        public static int MinimumElementIndex(int[] array)
        {
            if(array is null || array.Length < 1)
            {
                return 0;
            }
            int minIndex = 0;
            int minElement = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(minElement > array[i])
                {
                    minElement = array[i];
                    minIndex = i;
                }
            }

            return minIndex;

        }

    }
}
