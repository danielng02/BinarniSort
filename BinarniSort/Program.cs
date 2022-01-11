using System;

namespace BinarniSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 21, 19, 18, 15, 14, 13, 11, 9, 6, 2, 1, 0};

            int[] pole = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

            Console.WriteLine(binarySearch(pole, 0, 12, 2));
        }
        public static int binarySearch(int[] array, int leftIndex, int rightIndex, int value)
        {
            if (leftIndex == rightIndex && array[leftIndex] != value)
            {
                return -1;
            }

            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

            if (array[middleIndex] == value)
            {
                return middleIndex;
            }

            else if (array[middleIndex] > value)
            {
                return binarySearch(array, middleIndex + 1, rightIndex, value);
            }
            else
            {
                return binarySearch(array, leftIndex, Math.Max(leftIndex, middleIndex - 1), value);
            }
        }

        public static int binarySearchA(int[] array, int leftIndex, int rightIndex, int value)
        {
            int middleIndex = (leftIndex + rightIndex) / 2;

            if (leftIndex > rightIndex)
            {
                return -1;
            }

            if(leftIndex == rightIndex && array[leftIndex] != value)
            {
                return -1;
            }

            if(array[middleIndex] == value)
            {
                return middleIndex;
            }
            
            else if(array[middleIndex] > value)
            {
                return binarySearchA(array, leftIndex, middleIndex, value);
            }

            else
            {
                return binarySearchA(array, middleIndex, rightIndex, value);
            }
        }
    }
}
