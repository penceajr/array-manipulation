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

        private static int ReadNumber(string label)
        {
            if (string.IsNullOrEmpty(label))
            {
                label = "Please enter a numeric value=";
            }

            Console.Write(label);
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int result))
            {
                throw new Exception($"Input '{input}' does not represent a valid number");
            }

            return result;
        }

        private static int[] ReadArray(int length)
        {
            if (length < 0)
            {
                Console.WriteLine($"You have specified a negative length for the array ({length}), we will assume you mean an empty array!");
                return new int[0];
            }

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                int element = ReadNumber($"Please enter element[{i}]=");

                array[i] = element;
            }

            return array;
        }

        public static int[] GetArrayFromKeybord()
        {
            Console.WriteLine();
            Console.Write("Please provide your array: ");
            string  getArrayAsString = Console.ReadLine();
            string[] arrayAsString = getArrayAsString.Split(" ");
            int[] finalArray = new int[arrayAsString.Length];
            
            try
            {
                for (int i = 0; i < arrayAsString.Length; i++)
                {
                    finalArray[i] = int.Parse(arrayAsString[i]);
                }

                return finalArray;
            }
            catch (Exception)
            {
               Console.WriteLine("You have not entered a valid Array!");
               int ArrayLenght = ReadNumber("Dimensiunea vectorului=");
               int[] array = ReadArray(ArrayLenght);

                return array;
            }
            
        }

        public static void PrintArray(int[] array)
        {
            if (array is null)
            {
                Console.WriteLine("Array argument is null!");
                return;
            }

            Console.Write("Array: [");
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                Console.Write($"{element}");

                if (i < array.Length - 1)
                {
                    Console.Write($",");
                }
            }

            Console.Write("]");
        }
    }
}
