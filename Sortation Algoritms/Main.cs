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

        RandomManager Mrm = new RandomManager();
        SearchManager MSM = new SearchManager();
        SortManager Msm = new SortManager();

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


        // Sort
        public string Sort(string inputString)
        {
            Msm.SetSortBy = sortBy;
            Msm.SetAlgorithmType = algorithmType;

            string final = Msm.Sort(inputString);
            algorithmTime = Msm.GetAlgorithmTime;

            return final;
        }

        // Search
        public string  Search(string array, int search)
        {
            string final = "";
            final = MSM.Search(array, search, algorithmType);
            algorithmTime = MSM.GetAlgorithmTime;

            if (MSM.MessageCheck.Contains("The number was not find :("))
            {
                final = MSM.MessageCheck;
            }

            return final;

        }

        // Random Sort
        public string RandomNumber(int count, int first, int end, bool nonReapit)
        {
            return Mrm.RandomNumber(count, first, end, nonReapit);
        }

        // Random Search
        public string[] RandomSearch(int count, int first, int end, bool nonReapit, bool fill, bool outOfrange)
        {
            int index = 1;

            if (fill == true)
            {
                index = 2;
            }

            string[] str = new string[index];

            Mrm.RandomSearch(count, first, end, nonReapit, fill, outOfrange);
            
            if (fill == true)
            {
                str[0] = Mrm.GetOrigin;
                str[1] = Mrm.GetSecond;
            }
            else
            {
                str[0] = Mrm.GetOrigin;
            }
            
            return str;
        }

    }
}
