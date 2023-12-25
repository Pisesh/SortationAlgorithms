using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortation_Algoritms
{
    class Spliter
    {
        

        public int[] Splitor(string inputArray)
        {
            string tempNum = "";
            int count = 0; 
            int[] array = new int[Counter(inputArray)];

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
    }
}
