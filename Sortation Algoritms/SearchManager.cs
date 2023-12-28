using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortation_Algoritms
{
    class SearchManager
    {
        Search Src = new Search();
        Spliter split = new Spliter();
        private string message;
        private long algorithmTime;

        public long GetAlgorithmTime
        {
            get
            {
                return algorithmTime;
            }
        }

        public string MessageCheck
        {
            get
            {
                return message;
            }
        }



        public string Search(string array, int search, string algorithmType)
        {
            string final = "";
            int temp = 0;

            int arrayLength = split.Counter(array);

            int[] farray = new int[arrayLength];
            farray = split.Splitor(array, arrayLength);

            if (algorithmType == "Liner Search")
            {
                temp = Src.LinerSearch(farray, search);
                message = Src.MessageCheck;  
            }

            algorithmTime = Src.GetTimer;

            return final = Convert.ToString(temp);
        }

    }
}
