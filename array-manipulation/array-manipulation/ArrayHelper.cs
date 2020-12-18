using System;
using System.Collections.Generic;
using System.Linq;
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

        public static int MaximumElementIndex(int[] array)
        {
            if (array is null || array.Length < 1)
            {
                return 0;
            }
            int minIndex = 0;
            int minElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (minElement < array[i])
                {
                    minElement = array[i];
                    minIndex = i;
                }
            }

            return minIndex;

        }

        public static int[] ReturnOddElements(int[] array)
        {
            string usedForOddArray="";
            for (int i = 0, j=0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    usedForOddArray = usedForOddArray + $" {array[i]}";
                    j++;
                }
                    
            }

            int[] oddArray = new int[usedForOddArray.Split(" ").Count()-1];
            for(int a = 0; a < usedForOddArray.Split(" ").Count()-1; a++)
            {
                oddArray[a] = int.Parse(usedForOddArray.Split(" ",StringSplitOptions.RemoveEmptyEntries)[a].Trim());
            }
            return oddArray;
        }

        public static int[] ReturnEvenElements(int[] array)
        {
            string usedForOddArray = "";
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    usedForOddArray = usedForOddArray + $" {array[i]}";
                    j++;
                }

            }

            int[] oddArray = new int[usedForOddArray.Split(" ").Count() - 1];
            for (int a = 0; a < usedForOddArray.Split(" ").Count() - 1; a++)
            {
                oddArray[a] = int.Parse(usedForOddArray.Split(" ", StringSplitOptions.RemoveEmptyEntries)[a].Trim());
            }
            return oddArray;
        }

    }
}
