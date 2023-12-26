using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sortation_Algoritms
{
    class Sort
    {
        private long timer;
        Spliter Msp = new Spliter();

        // Bubble Sort

        public int[] BubbleSortDes(int[] array)
        {
            array = BubbleSortAsc(array);
            array = Msp.ReversNumberArray(array);

            return array;

        }

        public int[] BubbleSortAsc(int[] array)
        {
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();

            int temp = 0;
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            myWatch.Stop();

            timer = myWatch.ElapsedMilliseconds;
            return array;
        }

        // Selection Sort

        public int[] SelectionSortAsc(int[] array)
        {
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) 
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;                    
                    }
                }
            }
            myWatch.Stop();

            timer = myWatch.ElapsedMilliseconds;

            return array;
        }

        public int[] SelectionSortDes(int[] array)
        {
            array = SelectionSortAsc(array);
            array = Msp.ReversNumberArray(array);

            return array;
        }

        // Insertion Sort

        public int[] InsertionSortAsc(int[] array)
        {
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();

            int t , j , i;
            for (i = 1; i < array.Length; i++)
            {
                t = array[i];
                for (j = i; j > 0; j--)
                {
                    if (t >= array[j - 1])
                    {
                        break;
                    }
                    array[j] = array[j - 1];
                }
                array[j] = t;
            }
            myWatch.Stop();

            timer = myWatch.ElapsedMilliseconds;

            return array;
        }

        public int[] InsertionSortDsc(int[] array)
        {
            array = InsertionSortAsc(array);
            array = Msp.ReversNumberArray(array);

            return array;
        }

        // Quick Sort
        static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static int partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    swap(array, i, j);
                }
            }
            swap(array, i + 1, high);
            return (i + 1);
        }

        public int[] QuickSortAsc(int[] array, int low, int high)
        {
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();

            if (low < high)
            {
                int pi = partition(array, low, high);

                QuickSortAsc(array, low, pi - 1);
                QuickSortAsc(array, pi + 1, high);
            }
            myWatch.Stop();

            timer = myWatch.ElapsedMilliseconds;

            return array;
        }

        public int[] QuickSortDec(int[] array, int low, int high)
        {
            array = QuickSortAsc(array, low, high);
            array = Msp.ReversNumberArray(array);

            return array;
        }


        public long GetTimer
        {
            get{
                return timer;
            }
        }
    }
}
