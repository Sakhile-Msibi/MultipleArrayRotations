using System;

namespace MultipleArrayRotations
{
    class Program
    {
        public void leftRotate(int[] arr, int k)
        {
            int len = arr.Length;

            if (k == 0)
                return;

            k = k % len;

            int[] array = arr.Clone() as int[];

            rotateArray(array, 0, k - 1);
            rotateArray(array, k, len - 1);
            rotateArray(array, 0, len - 1);

            printArray(array);
        }

        public void rotateArray(int[] arr, int start, int end)
        {
            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + ", ");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 3, 5, 7, 9 };
            int k = 2;

            program.leftRotate(arr, k);

            k = 3;

            program.leftRotate(arr, k);

            k = 4;

            program.leftRotate(arr, k);
        }
    }
}
