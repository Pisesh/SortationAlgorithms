using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sortation_Algoritms
{
    class Search
    {
        private long timer;
        private string message; 

        public string MessageCheck
        {
            get
            {
                return message;
            }
        }

        public long GetTimer
        {
            get
            {
                return timer;
            }
        }

        public int LinerSearch (int[] array, int number)
        {
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();

            message = "";
            int i;

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    number = i;
                    break;
                }
            }
            if (i == array.Length)
            {
                message = "The number was not find :(";
            }

            myWatch.Stop();

            timer = myWatch.ElapsedMilliseconds;

            return number + 1;
        }

        public int BinarySearch (int[] array, int number)
        {
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();

            int min = 0;
            int max = array.Length - 1;
            int mid = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;

                if (array[mid] == number)
                {
                    return ++mid;
                }
                else if (array[mid] > number)
                {
                    min = mid - 1;
                }
                else
                {
                    max = mid + 1;
                }

            }

            message = "The number was not find: (";

            myWatch.Stop();

            timer = myWatch.ElapsedMilliseconds;

            return ++mid;
        }
    }
}
