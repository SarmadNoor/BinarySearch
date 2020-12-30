using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Binary search");
            int numberToBeSearched = int.Parse(Console.ReadLine());
            int[] sortedInput = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int startIndex = 0;
            int lastIndex = sortedInput.Length - 1;
            int searchedIndex = PerformBinarySearch(sortedInput, numberToBeSearched, startIndex, lastIndex);
            Console.WriteLine($"The index of searched number is - {searchedIndex}");
        }

        static int PerformBinarySearch(int[] sortedInput, int numberToBeSearched, int startIndex, int lastIndex)
        {
            int searchedIndex = -1;
            int midIndex = (startIndex + lastIndex)/ 2;
            if(sortedInput[midIndex] == numberToBeSearched)
            {
                searchedIndex = midIndex;
                return searchedIndex;
            }
            else if(sortedInput[midIndex] >  numberToBeSearched)
            {
                lastIndex = midIndex - 1;
               return PerformBinarySearch(sortedInput, numberToBeSearched, startIndex, lastIndex);
            }
            else if (sortedInput[midIndex] < numberToBeSearched)
            {
                startIndex = midIndex + 1;
               return PerformBinarySearch(sortedInput, numberToBeSearched, startIndex, lastIndex);
            }
            else
            {
                return -1;
            }     
        }
    }
}
