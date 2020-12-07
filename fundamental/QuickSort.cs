using System;

namespace Algorithm_DataStructure_Csharp
{
    class QuickSort
    {
        private int[] array = new int[20];
        private int length;

        public void QuickSortAlgorithm()
        {
            sort(0, length - 1);
        }

        private void sort(int left, int right)
        {
            int pivot, leftend, rightend;

            leftend = left;
            rightend = right;
            pivot = array[left];

            while (left < right)
            {
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }

                while ((array[left] >= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }
            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot) { sort(left, pivot - 1); }
            if (right > pivot)
            {
                sort(pivot + 1, right);
            }
        }

        public static void _Main()
        {
            QuickSort q_Sort = new QuickSort();

            int[] array = { 41, 32, 15, 45, 63, 72, 57, 43, 32, 52, 183 };
            q_Sort.array = array;
            q_Sort.length = q_Sort.array.Length;
            q_Sort.QuickSortAlgorithm();

            for (int j = 0; j < q_Sort.length; j++)
            {
                Console.WriteLine(q_Sort.array[j]);
            }
            Console.ReadKey();
        }
    }
}