using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace array_manipulation
{
    class Utils
    {
        public static int[] Clone(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                return new int[0];
            }

            int[] result = new int[array.Length];
            for (int index = 0; index < result.Length; index++)
            {
                result[index] = array[index];
            }

            return result;
        }

        public static int[] GetArrayFromKeybord()
        {
            Console.WriteLine("Please provide your array: ");
            string  getArrayAsString = Console.ReadLine();
            string[] arrayAsString = getArrayAsString.Split(" ");
            int[] finalArray = new int[arrayAsString.Length];

            for(int i=0; i < arrayAsString.Length; i++)
            {
                finalArray[i] = int.Parse(arrayAsString[i]);
            }

            return finalArray;
        }

    }
}
