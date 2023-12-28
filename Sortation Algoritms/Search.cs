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

    }
}
