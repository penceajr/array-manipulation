using System;

namespace array_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] array = { 1, 9, 2, 7, 13, 5, 11 };

            int[] array = Utils.Clone(Utils.GetArrayFromKeybord());

            //sa gaseasca indexul elementului minim

            Console.WriteLine($"The minimum element is found at index[{ArrayHelper.MinimumElementIndex(array)}]");

            //sa gaseasca indexul elementului maxim

            Console.WriteLine($"The maximum element is found at index[{ArrayHelper.MaximumElementIndex(array)}]");

            //sa ordoneze crescator elementele vectorului
            int[] arrayForAscendingOrder = Utils.Clone(array);
            Array.Sort(arrayForAscendingOrder);

            Console.WriteLine();
            Console.WriteLine($"Your array is sorted ascending ");
            Utils.PrintArray(arrayForAscendingOrder);

            //sa ordoneze descrescator elementele vectorului
            Array.Reverse(arrayForAscendingOrder);
            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine($"Your array is sorted descending ");
            Utils.PrintArray(arrayForAscendingOrder);
            Console.WriteLine();

            //sa intoarca un sub-vector reprezentand elementele pare
            int[] oddArray = ArrayHelper.ReturnOddElements(array);
            Console.WriteLine();
            Console.WriteLine($"Your odds elements array is ");
            Utils.PrintArray(oddArray);
            Console.WriteLine();

            //sa intoarca un sub-vector reprezentand elementele impare
            int[] evenArray = ArrayHelper.ReturnEvenElements(array);
            Console.WriteLine();
            Console.WriteLine($"Your even elements array is ");
            Utils.PrintArray(evenArray);
            Console.WriteLine();
        }
    }
}
