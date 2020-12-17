using System;

namespace array_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] array = { 1, 9, 2, 7, 13, 5, 11 };

            int[] array = Utils.Clone(Utils.GetArrayFromKeybord());

            Console.WriteLine($"The maximum element is found at index[{ArrayHelper.MinimumElementIndex(array)}]");

        }
    }
}
