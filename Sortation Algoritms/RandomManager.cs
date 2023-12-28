using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortation_Algoritms
{
    class RandomManager
    {
        RandomGenrator Mrg = new RandomGenrator();
        Spliter Msp = new Spliter();
        private string origin;
        private string second;

        public string GetOrigin
        {
            get
            {
                return origin;
            }
        }
        public string GetSecond
        {
            get
            {
                return second;
            }
        }

        public string RandomNumber(int count, int first, int end, bool nonReapit)
        {
            string final = "";
            int[] array = new int[count];

            if (nonReapit == true)
            {
                array = (Mrg.GenerateUniqueRandomNumbers(count, first, end).ToArray());
                final = Msp.Concat(array);
            }
            else
            {
                array = Mrg.RandomNumber(count, first, end);
                final = Msp.Concat(array);
            }
            return final;
        }



        public void RandomSearch(int count, int first, int end, bool nonReapit, bool fill, bool outOfrange)
        {
            int temp = 0;
            int num = 0;
            int counter = 0;

            origin = RandomNumber(count, first, end, nonReapit);

            if (fill == true)
            {
                if (outOfrange == true)
                {
                    temp = Mrg.RandomSingleNumber(0, 1);

                    if (temp == 0)
                    {
                        second = Convert.ToString(Mrg.RandomSingleNumber(first - 100, first - 1));
                    }
                    else
                    {
                        num = temp + temp;
                        second = Convert.ToString(Mrg.RandomSingleNumber(end + 1, end + 100));
                    }
                }
                else
                {
                    second = Convert.ToString(Mrg.RandomSingleNumber(first, end));
                }

            }
        }
    }
}
