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
        

        public int[] BubbleSortDes(int[] array)
        {
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();
           
            int temp = 0;
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] < array[j + 1])
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



        public long GetTimer
        {
            get{
                return timer;
            }
        }

    }
}
