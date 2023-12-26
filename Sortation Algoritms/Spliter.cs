using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortation_Algoritms
{
    class Spliter
    {
        

        public int[] Splitor(string inputArray, int counter)
        {
            string tempNum = "";
            int count = 0; 
            int[] array = new int[counter];

            for (int i = 0; i < inputArray.Length; i++)
            { 
                if (inputArray[i] == ',')
                {
                    array[count] = int.Parse(tempNum);
                    tempNum = "";
                    count++;
                }
                else
                {
                    tempNum = tempNum + inputArray[i];
                }   
            }

            array[count] = int.Parse(tempNum);

            return array;
        }

        public string Concat(int[] array)
        {
            string final = "";

            for (int i= 0; i < array.Length; i++)
            {
                final = final + array[i] + ",";
            }

            return final;
        }

        public int Counter(string inputArray)
        {
            char temp;
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                temp = inputArray[i];

                if (temp == ',')
                {
                    count++;
                }
            }

            return count + 1;
        }

        public int[] ReversNumberArray(int[] array)
        {
            int[] RArray = new int[array.Length];
            int count = 0;
            for (int i = array.Length - 1; i >= 0 ; i--) 
            {
                RArray[count] = array[i];
                count++;
            }
            return RArray;
        }
    }
}
