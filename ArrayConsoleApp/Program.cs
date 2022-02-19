using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int countOfInvalidEntries = 0;
            int countOfNumbersOutsideRange = 0;

            initArray(arr);
            countOfInvalidEntries = EnterValues(arr, ref countOfNumbersOutsideRange);
            Display(arr, countOfInvalidEntries, countOfNumbersOutsideRange);
            Console.ReadKey();
        }

        public static void initArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = -1;
        }

        public static int EnterValues(int[] array, ref int countOfNumbersOutsideRange)
        {
            int iVal = 0;
            string strVal;
            int countOfInvalidInputs = 0;
            int countOfUserInputs = 0;  // This should increase upto 10 as per the capacity specified in Line# 13
            bool isMoreInput = true;

            Console.Clear();
            while (isMoreInput)
            {
                Console.Write("\nEnter any number between 0 and 9 (-1 to exit): ");
                strVal = Console.ReadLine();

                while (int.TryParse(strVal, out iVal) == false)
                {
                    Console.Write("\nInvalid type! Enter any number between 0 and 9 (-1 to exit): ");
                    strVal = Console.ReadLine();
                    countOfInvalidInputs++;
                }

                if (iVal == -1)
                    isMoreInput = false;
                else if (iVal < -1 || iVal >= 10)
                {
                    Console.Write("\nInvalid number! Enter any number between 0 and 9 (-1 to exit): ");
                    countOfNumbersOutsideRange++;
                }
                else
                    array[countOfUserInputs++] = iVal;

                if (countOfUserInputs == 10)
                {
                    Console.WriteLine("You have exhausted the storage.");
                    isMoreInput = false;
                }
            }
            return countOfInvalidInputs;
        }

        public static void Display(int[] array, int invalidEntryCount, int inputOutsideRangeCount)
        {
            int contOfValidEntries = 0;

            Console.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != -1)
                {
                    Console.Write("{0, -12}\n", array[i]);
                    contOfValidEntries++;
                }
            }

            Console.WriteLine("\nNumber of valid entries: {0}", contOfValidEntries);
            Console.WriteLine("\nNumber of non-numeric entries: {0}", invalidEntryCount);
            Console.WriteLine("\nNumber of entries outside acceptable range: {0}", inputOutsideRangeCount);
            Console.WriteLine("\nTotal number of inputs entered by the user: {0}", 
                contOfValidEntries + invalidEntryCount + inputOutsideRangeCount);
        }
    }
}
