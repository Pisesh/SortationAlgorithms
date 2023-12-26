using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortation_Algoritms
{
    class Main
    {
        private string sortBy;
        private long algorithmTime;
        private string algorithmType;

        Spliter Msp = new Spliter();
        Sort Mso = new Sort();

        public string SetSortBy
        {
            set
            {
                sortBy = value;
            }
        }

        public long GetAlgorithmTime
        {
            get
            {
                return algorithmTime;
            }
        }

        public string SetAlgorithmType
        {
            set
            {
                algorithmType = value;
            }
        }

        public string Sort(string inputString)
        {
            int arrayLength = 0;
            string final = "";
            int[] array = new int[arrayLength];

            arrayLength = Msp.Counter(inputString);

            array = Msp.Splitor(inputString, arrayLength);

            if (algorithmType == "Bubble Sort")
            {
                if (sortBy == "Asc")
                {
                    array = Mso.BubbleSortAsc(array);
                }
                else
                {
                    array = Mso.BubbleSortDes(array);
                }
            }
            else if (algorithmType == "Selection Sort")
            {
                if (sortBy == "Asc")
                {
                    array = Mso.BubbleSortAsc(array);
                }
                else
                {
                    array = Mso.BubbleSortDes(array);
                }

            }
            else if (algorithmType == "Insertion Sort")
            {
                if (sortBy == "Asc")
                {
                    array = Mso.InsertionSortAsc(array);
                }
                else
                {
                    array = Mso.InsertionSortDsc(array);
                }
            }


            algorithmTime = Mso.GetTimer;
            final = Msp.Concat(array);

            return final;

        }

    }
}
