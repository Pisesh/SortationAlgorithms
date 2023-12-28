using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortation_Algoritms
{
    class RandomGenrator
    {
        public int[] RandomNumber(int count, int first, int end) 
        {
            Random rnd = new Random();
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(first, end);
            }

            return array;
        }

        public List<int> GenerateUniqueRandomNumbers(int count, int min, int max)
        {

            List<int> randomNumbers = new List<int>();
            Random random = new Random();

            while (randomNumbers.Count < count)
            {
                int randomNumber = random.Next(min, max + 1);
                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            return randomNumbers;
        }

        public int RandomSingleNumber(int first, int end)
        {
            Random rnd = new Random();

            return rnd.Next(first, end);
        }

    }
}